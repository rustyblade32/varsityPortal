using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VarsityPortal.Data;
using VarsityPortal.Models;

namespace VarsityPortal.Controllers
{
    [Authorize(Roles ="Student")]
    public class StudentsAreaController : Controller
    {
        private readonly VarsityContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public StudentsAreaController(VarsityContext context,
                                      UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        // GET: StudentsArea
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Courses()
        {
            var user = _userManager.GetUserName(User);

            var student = await _context.Students.Include(s => s.Enrollments)
                                  .ThenInclude(e => e.Section)
                                  .ThenInclude(se => se.Course)
                                  .Where(st => st.Email == user)
                                  .FirstOrDefaultAsync();

            var enrolls = student.Enrollments;

            return View(enrolls);
        }

        public async Task<IActionResult> ExamMarks(int Id)
        {
            var user = _userManager.GetUserName(User);

            var student = await _context.Students.Include(s => s.Enrollments)
                                  .ThenInclude(e => e.Section)
                                  .ThenInclude(se => se.Course)
                                  .Where(st => st.Email == user)
                                  .FirstOrDefaultAsync();

            var enroll = await _context.Enrollments.Include(e => e.marks)
                                       .Where(s => s.StudentId == student.Id & s.SectionId == Id).FirstOrDefaultAsync();

            var scores = enroll.marks;

            return View(scores);
        }

        public async Task<IActionResult> Profile(int id)
        {
            try
            {
                var user = _userManager.GetUserName(User);

                var student = await _context.Students.Include(s => s.Enrollments)
                                      .ThenInclude(e => e.Section)
                                      .ThenInclude(se => se.Course)
                                      .Where(st => st.Email == user)
                                      .FirstOrDefaultAsync();

                var enrolls = _context.Enrollments.Include(e => e.marks)
                                       .Where(s => s.StudentId == student.Id);

                var department = await _context.Departments.Where(d => d.Id == student.DepartmentId).FirstOrDefaultAsync();

                foreach(var enroll in enrolls)
                {
                    decimal sum = 0;
                    foreach(var mark in enroll.marks)
                    {
                        sum += mark.OutOf;
                    }
                    if(sum >= 100)
                    {
                        enroll.IsFinished = true;
                        enroll.gpa = enroll.CalculateGpa();
                        _context.Update(enroll);
                        
                    }
                }

                await _context.SaveChangesAsync();

                decimal creditSum = 0;
                decimal gpamul = 0;
                foreach (var enroll in enrolls)
                {
                    creditSum += Convert.ToDecimal(enroll.Section.Course.Credits);
                    gpamul += Convert.ToDecimal(enroll.Section.Course.Credits * enroll.gpa);

                }

                student.cgpa = gpamul / creditSum;

                    if (student == null)
                {
                    return NotFound();
                }
                student.Department = department;
                return View(student);
            }
            catch(Exception e)
            {
                return View();
            }
        }
        // GET: StudentsArea/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}