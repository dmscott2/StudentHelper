using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHelper.Pages.Courses
{
	public class CreateModel : PageModel
	{
		private readonly IConfiguration _configuration;
		private string _connectionString;
		DbContextOptionsBuilder<StudentHelperDbContext> _optionsBuilder;

		public CourseController(IConfiguration configuration)
		{
			_configuration = configuration;
			_optionsBuilder = new DbContextOptionsBuilder<StudentHelperDbContext>();
			_connectionString = _configuration.GetConnectionString("DefaultConnection");
			_optionsBuilder.UseSqlServer(_connectionString);
		}
		// GET: CourseController
		public ActionResult Index()
		{
			try
			{
				using (StudentHelperDbContext _context = new StudentHelperDbContext(_optionsBuilder.Options))
				{

					var courses = _context.Courses.ToList();
					return View(courses);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// GET: CourseController/Details/5
		public ActionResult Details(int id)
		{
			using (StudentHelperDbContext _context = new StudentHelperDbContext(_optionsBuilder.Options))
			{

				var course = _context.Courses.FirstOrDefault(s => s.CourseID == id);
				return View(course);
			}
		}

		// GET: CourseController/Create
		public ActionResult Create()
		{
			//using (StudentHelperDbContext _context = new StudentHelperDbContext(_optionsBuilder.Options))
			//{

			//	var students = _context.Students.ToList();
			//	ViewData["Students"] = students;
			//}

			return View();
		}

		// POST: CourseController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Course course)
		{
			try
			{

				using (StudentHelperDbContext _context = new StudentHelperDbContext(_optionsBuilder.Options))
				{

					var students = _context.Courses.Add(course);
					_context.SaveChanges();
				}

				return RedirectToAction(nameof(Index));
			}
			catch (Exception ex)
			{
				return View();
			}
		}

		// GET: CourseController/Edit/5
		public ActionResult Edit(int id)
		{
			try
			{
				using (StudentHelperDbContext _context = new StudentHelperDbContext(_optionsBuilder.Options))
				{

					var course = _context.Courses.FirstOrDefault(s => s.CourseID == id);
					return View(course);
				}

			}
			catch (Exception)
			{

				throw;
			}
		}

		// POST: CourseController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Course course)
		{
			try
			{
				using (StudentHelperDbContext _context = new StudentHelperDbContext(_optionsBuilder.Options))
				{
					_context.Courses.Update(course);
					_context.SaveChanges();
				}

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: CourseController/Delete/5
		public ActionResult Delete(int id)
		{
			try
			{
				using (StudentHelperDbContext _context = new StudentHelperDbContext(_optionsBuilder.Options))
				{

					var course = _context.Courses.FirstOrDefault(s => s.CourseID == id);
					return View(course);
				}

			}
			catch (Exception)
			{

				throw;
			}
		}

		// POST: CourseController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Course course)
		{
			try
			{
				using (StudentHelperDbContext _context = new StudentHelperDbContext(_optionsBuilder.Options))
				{
					course.CourseID = id;
					_context.Courses.Remove(course);
					_context.SaveChanges();
				}

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}