using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VarsityPortal.Data;
using VarsityPortal.Models;

namespace VarsityPortal.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SectionsController : Controller
    {
        private readonly VarsityContext _context;

        public SectionsController(VarsityContext context)
        {
            _context = context;
        }

        // GET: Sections
        public async Task<IActionResult> Index()
        {
            var varsityContext = _context.Sections.Include(s => s.Course).Include(s => s.Teacher);
            return View(await varsityContext.ToListAsync());
        }

        // GET: Sections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sections = await _context.Sections
                .Include(s => s.Course)
                .Include(s => s.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sections == null)
            {
                return NotFound();
            }

            return View(sections);
        }

        // GET: Sections/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, nameof(Course.Id), nameof(Course.Code));
            ViewData["TeacherId"] = new SelectList(_context.Teachers, nameof(Teacher.Id), nameof(Teacher.FirstName));
            return View();
        }

        // POST: Sections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Year,Semester,Number,CourseId,TeacherId")] Sections sections)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sections);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, nameof(Course.Id), nameof(Course.Code), sections.CourseId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers, nameof(Teacher.Id), nameof(Teacher.FirstName), sections.TeacherId);
            return View(sections);
        }

        // GET: Sections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sections = await _context.Sections.FindAsync(id);
            if (sections == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, nameof(Course.Id), nameof(Course.Code), sections.CourseId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers, nameof(Teacher.Id), nameof(Teacher.FirstName), sections.TeacherId);
            return View(sections);
        }

        // POST: Sections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Year,Semester,Number,CourseId,TeacherId")] Sections sections)
        {
            if (id != sections.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sections);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SectionsExists(sections.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, nameof(Course.Id), nameof(Course.Code), sections.CourseId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers, nameof(Teacher.Id), nameof(Teacher.FirstName), sections.TeacherId);
            return View(sections);
        }

        // GET: Sections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sections = await _context.Sections
                .Include(s => s.Course)
                .Include(s => s.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sections == null)
            {
                return NotFound();
            }

            return View(sections);
        }

        // POST: Sections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sections = await _context.Sections.FindAsync(id);
            _context.Sections.Remove(sections);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SectionsExists(int id)
        {
            return _context.Sections.Any(e => e.Id == id);
        }
    }
}
