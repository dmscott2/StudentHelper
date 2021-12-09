using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentHelper.Models;

namespace StudentHelper.Pages.StudentAssignments
{
    public class DetailsModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;

        public DetailsModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
