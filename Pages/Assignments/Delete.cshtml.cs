using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentHelper.Models;

namespace StudentHelper.Pages.Assignments
{
    public class DeleteModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;

        public DeleteModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Assignment Assignment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assignment = await _context.Assignments
                .Include(a => a.Course)
                .Include(a => a.Student).FirstOrDefaultAsync(m => m.AssignmentId == id);

            if (Assignment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assignment = await _context.Assignments.FindAsync(id);

            if (Assignment != null)
            {
                _context.Assignments.Remove(Assignment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
