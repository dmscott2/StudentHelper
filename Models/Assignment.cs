using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentHelper.Models
{
    public class Assignment
    {
        public int AssignmentID { get; set; } // primary key

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string AssignmentDesc { get; set; }

        [Display(Name = "Assignment Due Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime AssignmentDueDate { get; set; }
        public List <StudentAssignment> StudentAssignments {get; set;} 
    }

        public class StudentAssignment
    {
        public int CourseID {get; set;}
        public int StudentID {get; set;}    // Composite Primary Key, Foreign Key 1
        public int AssignmentID {get; set;} // Composite Primary Key, Foreign Key 2

        public string CourseName {get;set; }
        public Course Course {get; set;}
        public Student Student {get; set;}  // Navigation Property. 
        public Assignment Assignment {get; set;} // Navigation Property. Multiple Assignments per
    }
}