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
    public class IndexModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;

        public IndexModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }
        
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        public IActionResult OnGet(){
            Course = _context.Courses.Skip((PageNum-1)*PageSize).Take(PageSize).ToList();
            return Page();
        }
    }
}
