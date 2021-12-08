using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHelper.Models
{
    public class Course
    {
        public int CourseID { get; set; } // primary key

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CourseName { get; set; }
        //public int StudentId { get; set; }
        //public Student Student { get; set; }
        public List<Assignment> Assignments { get; set; } // Navigation property to Assignments
    }
}