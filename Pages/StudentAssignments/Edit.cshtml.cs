using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentHelper.Models;

namespace StudentHelper.Pages.StudentAssignments
{
    public class EditModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;

        public EditModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StudentAssignment StudentAssignment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            StudentAssignment = await _context.StudentAssignments
                .Include(s => s.Assignment)
                .Include(s => s.Course)
                .Include(s => s.Student).FirstOrDefaultAsync(m => m.StudentID == id);

            if (StudentAssignment == null)
            {
                return NotFound();
            }
           ViewData["AssignmentID"] = new SelectList(_context.Assignments, "AssignmentID", "AssignmentDesc");
           ViewData["CourseID"] = new SelectList(_context.Courses, "CourseID", "CourseName");
           ViewData["StudentID"] = new SelectList(_context.Students, "StudentID", "StudentID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StudentAssignment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentAssignmentExists(StudentAssignment.StudentID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentAssignmentExists(int id)
        {
            return _context.StudentAssignments.Any(e => e.StudentID == id);
        }
    }
}
