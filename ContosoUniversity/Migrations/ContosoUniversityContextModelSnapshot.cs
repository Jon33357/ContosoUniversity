﻿// <auto-generated />
using ContosoUniversity.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ContosoUniversity.Migrations
{
    [DbContext(typeof(ContosoUniversityContext))]
    partial class ContosoUniversityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContosoUniversity.Models.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnName("CourseID");

                    b.Property<int>("Credits");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Entities.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .HasColumnName("EnrollmentID");

                    b.Property<int>("CourseId")
                        .HasColumnName("CourseID");

                    b.Property<int?>("Grade");

                    b.Property<int>("StudentId")
                        .HasColumnName("StudentID");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Entities.Enrollment", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Entities.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_Enrollment_Course");

                    b.HasOne("ContosoUniversity.Models.Entities.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .HasConstraintName("FK_Enrollment_Student");
                });
#pragma warning restore 612, 618
        }
    }
}
