using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentHelper.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentHelperDbContext (serviceProvider.GetRequiredService<DbContextOptions<StudentHelperDbContext>>()))
            {
                if (context.Courses.Any())

                {
                    return;
                }

                List<Course> Courses = new List<Course> {
                    new Course {CourseName = "Investments"},
                    new Course {CourseName = "Strategic Management"},
                    new Course {CourseName = "Advanced Programming"},
                    new Course {CourseName = "History"},
                    new Course {CourseName = "Math"},
                    new Course {CourseName = "Science"},
                    new Course {CourseName = "Accounting"},
                    new Course {CourseName = "Programming"},
                    new Course {CourseName = "Government"},
                    new Course {CourseName = "Statistics"},
                    };
                context.AddRange(Courses);

                List<Student> Students = new List<Student> {
                    new Student {StudentFirstName="Mookie", StudentLastName="Betts", StudentEmail="mookie.betts@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Corey", StudentLastName="Seager", StudentEmail="corey.seager@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Justin", StudentLastName="Turner", StudentEmail="justin.turner@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Clayton", StudentLastName="Kershaw", StudentEmail="clayton.kershaw@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Zoe", StudentLastName="Scott", StudentEmail="zoe.scott@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Dawn", StudentLastName="Scott", StudentEmail="dawn.scott@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Ryan", StudentLastName="Smith", StudentEmail="ryan.smith@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Jackson", StudentLastName="Brown", StudentEmail="jackson.brown@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Rachel", StudentLastName="Adams", StudentEmail="rachel.adams@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Mike", StudentLastName="Turner", StudentEmail="mike.turner@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Arnold", StudentLastName="Johnson", StudentEmail="arnold.johnson@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Melissa", StudentLastName="Tucker", StudentEmail="melissa.tucker@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Mason", StudentLastName="Riley", StudentEmail="mason.riley@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Jason", StudentLastName="Smith", StudentEmail="jason.smith@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Breanna", StudentLastName="McAdams", StudentEmail="breanna.mcadams@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Max", StudentLastName="Lowe", StudentEmail="max.lowe@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Smith", StudentLastName="Ryan", StudentEmail="smith.ryan@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Lisa", StudentLastName="Moore", StudentEmail="lisa.moore@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Chris", StudentLastName="Taylor", StudentEmail="chris.taylor@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Steve", StudentLastName="Miller", StudentEmail="Steve.Miller@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Christina", StudentLastName="White", StudentEmail="christina.white@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Addison", StudentLastName="Williams", StudentEmail="addison.williams@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Glenn", StudentLastName="Davis", StudentEmail="glenn.davis@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Hilary", StudentLastName="Anderson", StudentEmail="hilary.anderson@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                    new Student {StudentFirstName="Belinda", StudentLastName="Reese", StudentEmail="belinda.reese@test.com", RegistrationDate = DateTime.Parse("2021-12-5")},
                };
                context.AddRange(Students);

                List<StudentCourse> enrollment = new List<StudentCourse> {
                    new StudentCourse {CourseID = 1, StudentID = 1},
                    new StudentCourse {CourseID = 2, StudentID = 2},
                    new StudentCourse {CourseID = 3, StudentID = 3},
                    new StudentCourse {CourseID = 4, StudentID = 4},
                    new StudentCourse {CourseID = 5, StudentID = 5},
                    new StudentCourse {CourseID = 6, StudentID = 6},
                    new StudentCourse {CourseID = 7, StudentID = 7},
                    new StudentCourse {CourseID = 8, StudentID = 8},
                    new StudentCourse {CourseID = 9, StudentID = 9},
                    new StudentCourse {CourseID = 10, StudentID = 10},
                    new StudentCourse {CourseID = 1, StudentID = 11},
                    new StudentCourse {CourseID = 2, StudentID = 12},
                    new StudentCourse {CourseID = 3, StudentID = 13},
                    new StudentCourse {CourseID = 4, StudentID = 14},
                    new StudentCourse {CourseID = 5, StudentID = 15},
                    new StudentCourse {CourseID = 6, StudentID = 16},
                    new StudentCourse {CourseID = 7, StudentID = 17},
                    new StudentCourse {CourseID = 8, StudentID = 18},
                    new StudentCourse {CourseID = 9, StudentID = 19},
                    new StudentCourse {CourseID = 10, StudentID = 20},
                    new StudentCourse {CourseID = 9, StudentID = 21},
                    new StudentCourse {CourseID = 8, StudentID = 22},
                    new StudentCourse {CourseID = 7, StudentID = 23},
                    new StudentCourse {CourseID = 6, StudentID = 24},
                    new StudentCourse {CourseID = 5, StudentID = 25},
                };
                context.AddRange(enrollment);

                    List<Assignment> Assignments = new List<Assignment> {
                    new Assignment {AssignmentDesc = "Homework1", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                    new Assignment {AssignmentDesc = "Homework2", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                    new Assignment {AssignmentDesc = "Homework3", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                    new Assignment {AssignmentDesc = "Test1", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                    new Assignment {AssignmentDesc = "Test2", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                    new Assignment {AssignmentDesc = "Test3", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                    new Assignment {AssignmentDesc = "Project1", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                    new Assignment {AssignmentDesc = "Project2", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                    new Assignment {AssignmentDesc = "Quiz1", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                    new Assignment {AssignmentDesc = "Quiz1", AssignmentDueDate=DateTime.Parse("2021-12-30")},
                };
                context.AddRange(Assignments);

                    List<StudentAssignment> courseassignments = new List<StudentAssignment> {
                    new StudentAssignment {CourseID = 1, StudentID = 1, AssignmentID = 1},
                    new StudentAssignment {CourseID = 2, StudentID = 2, AssignmentID = 2},
                    new StudentAssignment {CourseID = 3, StudentID = 3, AssignmentID = 3},
                    new StudentAssignment {CourseID = 4, StudentID = 4, AssignmentID = 4},
                    new StudentAssignment {CourseID = 5, StudentID = 5, AssignmentID = 5},
                    new StudentAssignment {CourseID = 6, StudentID = 6, AssignmentID = 6},
                    new StudentAssignment {CourseID = 7, StudentID = 7, AssignmentID = 7},
                    new StudentAssignment {CourseID = 8, StudentID = 8, AssignmentID = 8},
                    new StudentAssignment {CourseID = 9, StudentID = 9, AssignmentID = 9},
                    new StudentAssignment {CourseID = 10, StudentID = 10, AssignmentID = 10},
                    new StudentAssignment {CourseID = 1, StudentID = 11, AssignmentID = 1},
                    new StudentAssignment {CourseID = 2, StudentID = 12, AssignmentID = 2},
                    new StudentAssignment {CourseID = 3, StudentID = 13, AssignmentID = 3},
                    new StudentAssignment {CourseID = 4, StudentID = 14, AssignmentID = 4},
                    new StudentAssignment {CourseID = 5, StudentID = 15, AssignmentID = 5},
                    new StudentAssignment {CourseID = 6, StudentID = 16, AssignmentID = 6},
                    new StudentAssignment {CourseID = 7, StudentID = 17, AssignmentID = 7},
                    new StudentAssignment {CourseID = 8, StudentID = 18, AssignmentID = 8},
                    new StudentAssignment {CourseID = 9, StudentID = 19, AssignmentID = 9},
                    new StudentAssignment {CourseID = 10, StudentID = 20, AssignmentID = 10},
                    new StudentAssignment {CourseID = 9, StudentID = 21, AssignmentID = 1},
                    new StudentAssignment {CourseID = 8, StudentID = 22, AssignmentID = 2},
                    new StudentAssignment {CourseID = 7, StudentID = 23, AssignmentID = 3},
                    new StudentAssignment {CourseID = 6, StudentID = 24, AssignmentID = 4},
                    new StudentAssignment {CourseID = 5, StudentID = 25, AssignmentID = 5},
                };
                context.AddRange(courseassignments);
                
                context.SaveChanges();
    
                }
            }
        }
    }