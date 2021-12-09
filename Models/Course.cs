using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentHelper.Models
{
    public class Course
    {
        public int CourseID { get; set; } // primary key

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CourseName { get; set; }
        public List<Assignment> Assignments { get; set; } // Navigation property to Assignments
        public List<StudentCourse> StudentCourses {get;set;}
    }

        public class StudentCourse
    {
        public int CourseID {get; set;}     // Composite Primary Key, Foreign Key 1
        public int StudentID {get; set;}    // Composite Primary Key, Foreign Key 2
        public Student Student {get; set;}  // Navigation Property. One Student per StudentCourse
        public Course Course {get; set;}    // Navigation Property. One Course per StudentCourse
    }
}