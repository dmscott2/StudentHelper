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
    public class DetailsModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;

        public DetailsModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;
        }

        public Assignment Assignment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Assignment = await _context.Assignments.FirstOrDefaultAsync(m => m.AssignmentID == id);

            if (Assignment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
