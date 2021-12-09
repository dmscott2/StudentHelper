using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentHelper.Models;

namespace StudentHelper.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;

        public CreateModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            Student = new Student();
            Student.RegistrationDate  = DateTime.Now;
        ViewData["StudentID"] = new SelectList(_context.Students, "StudentID", "StudentEmail");
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}