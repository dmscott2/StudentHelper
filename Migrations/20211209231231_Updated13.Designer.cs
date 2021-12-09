﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentHelper.Models;

namespace StudentHelper.Migrations
{
    [DbContext(typeof(StudentHelperDbContext))]
    [Migration("20211209231231_Updated13")]
    partial class Updated13
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("StudentHelper.Models.Assignment", b =>
                {
                    b.Property<int>("AssignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AssignmentDesc")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AssignmentDueDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CourseID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StudentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("AssignmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("StudentHelper.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudentHelper.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StudentLastName")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentHelper.Models.StudentAssignment", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AssignmentID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AssignmentDesc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AssignmentDueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CourseID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentID", "AssignmentID");

                    b.HasIndex("AssignmentID");

                    b.HasIndex("CourseID");

                    b.ToTable("StudentAssignments");
                });

            modelBuilder.Entity("StudentHelper.Models.StudentCourse", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CourseID", "StudentID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("StudentHelper.Models.Assignment", b =>
                {
                    b.HasOne("StudentHelper.Models.Course", null)
                        .WithMany("Assignments")
                        .HasForeignKey("CourseID");

                    b.HasOne("StudentHelper.Models.Student", null)
                        .WithMany("Assignments")
                        .HasForeignKey("StudentID");
                });

            modelBuilder.Entity("StudentHelper.Models.StudentAssignment", b =>
                {
                    b.HasOne("StudentHelper.Models.Assignment", "Assignment")
                        .WithMany("StudentAssignments")
                        .HasForeignKey("AssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentHelper.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentHelper.Models.Student", "Student")
                        .WithMany("StudentAssignments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentHelper.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentHelper.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentHelper.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentHelper.Models.Assignment", b =>
                {
                    b.Navigation("StudentAssignments");
                });

            modelBuilder.Entity("StudentHelper.Models.Course", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("StudentHelper.Models.Student", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("StudentAssignments");

                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
