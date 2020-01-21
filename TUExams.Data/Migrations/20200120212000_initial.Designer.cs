﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TUExams.Data;

namespace TUExams.Data.Migrations
{
    [DbContext(typeof(TUExamContext))]
    [Migration("20200120212000_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TUExams.Data.Models.Course", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TUExams.Data.Models.Exam", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<string>("FacultyId");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("TUExams.Data.Models.Faculty", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("TUExams.Data.Models.Exam", b =>
                {
                    b.HasOne("TUExams.Data.Models.Course", "Course")
                        .WithMany("Exams")
                        .HasForeignKey("CourseId");

                    b.HasOne("TUExams.Data.Models.Faculty", "Faculty")
                        .WithMany("Exams")
                        .HasForeignKey("FacultyId");
                });
#pragma warning restore 612, 618
        }
    }
}
