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

		// STEP 1: Add DBSet<> to model for each entity class
		public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
    }
}