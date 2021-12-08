using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentHelper.Models;

namespace StudentHelper.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;

        public DetailsModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Courses
                .Include(a => a.CourseName).FirstOrDefaultAsync(m => m.CourseId == id);
               
            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
