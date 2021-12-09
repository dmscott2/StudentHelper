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
    public class IndexModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;

        public IndexModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;
        }

        public IList<StudentAssignment> StudentAssignment { get;set; }

        [BindProperty(SupportsGet =true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet =true)]
        public string CurrentSort {get; set; }

        public async Task OnGetAsync()
        {
            var query = _context.StudentAssignments.Select(s => s);

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(s => s.StudentID);
                    break;
                case "first_desc":
                    query = query.OrderByDescending(s => s.StudentID);
                    break;
            }
            StudentAssignment = await query.Include(s => s.Assignment).Include(s => s.Course).Include(s => s.Student).Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
