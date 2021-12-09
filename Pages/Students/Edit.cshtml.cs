using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentHelper.Models;
using Microsoft.Extensions.Logging;

namespace StudentHelper.Pages.Students
{
        public class EditModel : PageModel
    {
        private readonly StudentHelper.Models.StudentHelperDbContext _context;
        private readonly ILogger _logger;

        public EditModel(StudentHelper.Models.StudentHelperDbContext context)
        {
            _context = context;

        }

        [BindProperty]
        public Student Student { get; set; } // This is the specific Student you are editing
        public List<Course> Courses {get; set;} // This is a list of all courses

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Bring in related data using Include and ThenInclude
            Student = await _context.Students.Include(s => s.StudentCourses).ThenInclude(sc => sc.Course).FirstOrDefaultAsync(m => m.StudentID == id);
            // Get a list of all courses. This list is used to make the checkboxes
            Courses = _context.Courses.ToList();

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int[] selectedCourses)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Attach(Student).State = EntityState.Modified;
            // Find the student you want to update and update all their "normal properties" (FirstName and LastName)
            var studentToUpdate = await _context.Students.Include(s => s.StudentCourses).ThenInclude(sc => sc.Course).FirstOrDefaultAsync(m => m.StudentID == Student.StudentID);
            studentToUpdate.StudentFirstName = Student.StudentFirstName;
            studentToUpdate.StudentLastName = Student.StudentLastName;

            // Separate method to update the courses because it can get complex
            UpdateStudentCourses(selectedCourses, studentToUpdate);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(Student.StudentID))
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

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentID == id);
        }

        private void UpdateStudentCourses(int[] selectedCourses, Student studentToUpdate)
        {
            if (selectedCourses == null)
            {
                studentToUpdate.StudentCourses = new List<StudentCourse>();
                return;
            }

            List<int> currentCourses = studentToUpdate.StudentCourses.Select(c => c.CourseID).ToList();
            List<int> selectedCoursesList = selectedCourses.ToList();

            foreach (var course in _context.Courses)
            {
                if (selectedCoursesList.Contains(course.CourseID))
                {
                    if (!currentCourses.Contains(course.CourseID))
                    {
                        // Add course here
                        studentToUpdate.StudentCourses.Add(
                            new StudentCourse { StudentID = studentToUpdate.StudentID, CourseID = course.CourseID }
                        );
                        _logger.LogWarning($"Student {studentToUpdate.StudentFirstName} {studentToUpdate.StudentLastName} ({studentToUpdate.StudentID}) - ADD {course.CourseID} {course.CourseName}");
                    }
                }
                else
                {
                    if (currentCourses.Contains(course.CourseID))
                    {
                        // Remove course here
                        StudentCourse courseToRemove = studentToUpdate.StudentCourses.SingleOrDefault(s => s.CourseID == course.CourseID);
                        _context.Remove(courseToRemove);
                        _logger.LogWarning($"Student {studentToUpdate.StudentFirstName} {studentToUpdate.StudentLastName} ({studentToUpdate.StudentID}) - DROP {course.CourseID} {course.CourseName}");
                    }
                }
            }
        }
    }
}