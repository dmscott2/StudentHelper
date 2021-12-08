using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHelper.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; } // primary key

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string AssignmentDesc { get; set; }

        [Display(Name = "Assignment Due Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime AssignmentDueDate { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}