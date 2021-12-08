using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHelper.Models
{
    public class Student
    {
        public int StudentId { get; set; } // primary key
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentEmail { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now; //date/time set by system
        public List<Assignment> Assignments { get; set; } // Navigation property to Assignments
    }
}
