using Microsoft.EntityFrameworkCore;
using StudentHelper.Models;

namespace StudentHelper.Models
{
    public class StudentHelperDbContext : DbContext
    {
		public StudentHelperDbContext(DbContextOptions<StudentHelperDbContext> options)
			: base(options)
		{
		}
		    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(s => new {s.CourseID, s.StudentID});
			modelBuilder.Entity<StudentAssignment>().HasKey(a => new {a.StudentID, a.AssignmentID});
        }

		// STEP 1: Add DBSet<> to model for each entity class
		public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
		public DbSet<StudentCourse> StudentCourses {get; set;}
		public DbSet<StudentAssignment> StudentAssignments {get; set;}
    }
}