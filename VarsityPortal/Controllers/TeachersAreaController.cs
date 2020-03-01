using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using VarsityPortal.Data;
using VarsityPortal.Models;
using Microsoft.AspNetCore.Authorization;

namespace VarsityPortal.Controllers
{
    [Authorize(Roles = "Teacher")]
    public class TeachersAreaController : Controller
    {
        private readonly VarsityContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public TeachersAreaController(VarsityContext context,
                                      UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: TeachersArea
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GiveMarks()
        {
            var user = _userManager.GetUserName(User);

            var teacher = await _context.Teachers.Include(t => t.Sections)
                                  .ThenInclude(s => s.Course)
                                  .Where(tc => tc.Email == user)
                                  .FirstOrDefaultAsync();

            var sections = teacher.Sections;

            return View(sections);

        }

        public async Task<IActionResult> StudentMarks(int Id)
        {
            var enrolls = _context.Enrollments
                                  .Include(e => e.Student)
                                  .Where(c => c.SectionId == Id);

            List<Mark> marks = new List<Mark>();

            foreach(var item in enrolls)
            {
                marks.Add(new Mark
                {
                    Enrollment = item,

                });
            }
            return View(marks);
        }

        // GET: TeachersArea/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TeachersArea/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeachersArea/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(List<Mark> model)
        {
            try
            {
                // TODO: Add insert logic here
                
                foreach(var item in model)
                {
                    item.ExamName = model[0].ExamName;
                    item.OutOf = model[0].OutOf;
                    _context.Add(item);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View();
            }
        }

        public async Task<IActionResult> Marks(int Id)
        {
            var enrolls = _context.Enrollments
                                  .Include(e => e.Student)
                                  .Where(c => c.SectionId == Id);

            List<Mark> marks = new List<Mark>();

            foreach (var item in enrolls)
            {
                marks.Add(new Mark
                {
                    Enrollment = item,

                });
            }
            return View(marks);
        }

        // GET: TeachersArea/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TeachersArea/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeachersArea/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TeachersArea/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}