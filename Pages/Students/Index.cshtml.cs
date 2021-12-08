using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentHelper.Models;

namespace StudentHelper.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;

        public IndexModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students
                .Include(a => a.Course)
                .Include(a => a.Assignment).ToListAsync();
        }
    }
}