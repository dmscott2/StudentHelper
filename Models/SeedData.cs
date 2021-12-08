using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;

namespace StudentHelper.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new StudentHelperDbContext (serviceProvider.GetRequiredService<DbContextOptions<StudentHelperDbContext>>()))
            {
                if (db.Students.Any())
                {
                    return;
                }

                db.Students.AddRange(
                    new Student
                    {
                        StudentFirstName = "Mookie",
                        StudentLastName = "Betts",
                        StudentEmail = "mookie.betts@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },

                    new Student
                    {
                        StudentFirstName = "Corey",
                        StudentLastName = "Seager",
                        StudentEmail = "corey.seager@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },

                    new Student
                    {
                        StudentFirstName = "Clayton",
                        StudentLastName = "Kershaw",
                        StudentEmail = "clayton.kershaw@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },

                    new Student
                    {
                        StudentFirstName = "Justin",
                        StudentLastName = "Turner",
                        StudentEmail = "justin.turner@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },
                        new Student
                    {
                        StudentFirstName = "Dawn",
                        StudentLastName = "Scott",
                        StudentEmail = "dawn.scott@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },
                        new Student
                    {
                        StudentFirstName = "Ryan",
                        StudentLastName = "Smith",
                        StudentEmail = "ryan.smith@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },
                        new Student
                    {
                        StudentFirstName = "Jacob",
                        StudentLastName = "Williams",
                        StudentEmail = "jacob.williams@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },
                        new Student
                    {
                        StudentFirstName = "Zoe",
                        StudentLastName = "Scott",
                        StudentEmail = "zoe.scott@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },
                        new Student
                    {
                        StudentFirstName = "Jessica",
                        StudentLastName = "Ryan",
                        StudentEmail = "jessica.ryan@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },
                        new Student
                    {
                        StudentFirstName = "Melissa",
                        StudentLastName = "Tucker",
                        StudentEmail = "melissa.tucker@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },
                        new Student
                    {
                        StudentFirstName = "Rachel",
                        StudentLastName = "Adams",
                        StudentEmail = "rachel.adams@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },
                        new Student
                    {
                        StudentFirstName = "Mike",
                        StudentLastName = "Arnold",
                        StudentEmail = "mike.arnold@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    },
                        new Student
                    {
                        StudentFirstName = "Max",
                        StudentLastName = "Turner",
                        StudentEmail = "max.turner@test.com",
                        RegistrationDate = DateTime.Parse("2021-12-5"),
                    }
                );
                db.SaveChanges();
            }
        }
    }
}