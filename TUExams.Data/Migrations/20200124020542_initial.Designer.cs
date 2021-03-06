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
    [Migration("20200124020542_initial")]
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

                    b.HasData(
                        new
                        {
                            Id = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c",
                            Number = 1
                        },
                        new
                        {
                            Id = "d2d35048-1d12-4621-82d1-5529d7563c2f",
                            Number = 2
                        },
                        new
                        {
                            Id = "41aee425-0155-42c0-a684-7b942c10a96a",
                            Number = 3
                        },
                        new
                        {
                            Id = "8ffa306b-e326-4752-9035-d060827f392d",
                            Number = 4
                        });
                });

            modelBuilder.Entity("TUExams.Data.Models.Exam", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CourseId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<int>("ExamHall");

                    b.Property<string>("FacultyId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            Id = "55f7dc5f-c803-42ab-8ea6-73828fb71182",
                            CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c",
                            Date = new DateTime(2020, 1, 23, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 1152,
                            FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799",
                            Title = "Физика 1 "
                        },
                        new
                        {
                            Id = "48619be3-aba2-4159-aef5-c9ebef9983f8",
                            CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c",
                            Date = new DateTime(2020, 1, 29, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 1153,
                            FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799",
                            Title = "Математика 1 "
                        },
                        new
                        {
                            Id = "bde0cb83-2136-40f1-b592-3276c57e9284",
                            CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f",
                            Date = new DateTime(2020, 1, 29, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 90,
                            ExamHall = 1154,
                            FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799",
                            Title = "Химия "
                        },
                        new
                        {
                            Id = "2c8fa666-c8d9-495d-b116-efb61672eeb1",
                            CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f",
                            Date = new DateTime(2020, 1, 24, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 2130,
                            FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799",
                            Title = "Математика 3"
                        },
                        new
                        {
                            Id = "a905c64f-f2f6-43b2-9e04-0fc118e86be8",
                            CourseId = "41aee425-0155-42c0-a684-7b942c10a96a",
                            Date = new DateTime(2020, 1, 27, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 90,
                            ExamHall = 12152,
                            FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799",
                            Title = "Програмиране и използване на компютри 2"
                        },
                        new
                        {
                            Id = "3b1028c0-0ef4-48ed-b748-881a6b218a32",
                            CourseId = "41aee425-0155-42c0-a684-7b942c10a96a",
                            Date = new DateTime(2020, 1, 23, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 2140,
                            FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799",
                            Title = "Физика 2"
                        },
                        new
                        {
                            Id = "43bfdfb5-83d3-466f-be29-622962619744",
                            CourseId = "8ffa306b-e326-4752-9035-d060827f392d",
                            Date = new DateTime(2020, 1, 27, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 120,
                            ExamHall = 2130,
                            FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799",
                            Title = "Бази от Данни"
                        },
                        new
                        {
                            Id = "0865d346-69fe-4866-8fe2-1f9611a84fe2",
                            CourseId = "8ffa306b-e326-4752-9035-d060827f392d",
                            Date = new DateTime(2020, 1, 24, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = 90,
                            ExamHall = 1152,
                            FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799",
                            Title = "Програмиране и използване на компютри 3"
                        },
                        new
                        {
                            Id = "8fecb0b9-c0e3-418d-9243-60173db9b187",
                            CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c",
                            Date = new DateTime(2020, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 2130,
                            FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6",
                            Title = "Физика 1 "
                        },
                        new
                        {
                            Id = "785a291d-b4c3-42f3-a949-c09b8f676719",
                            CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c",
                            Date = new DateTime(2020, 1, 29, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 2140,
                            FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6",
                            Title = "Математика  1 "
                        },
                        new
                        {
                            Id = "21a11635-216a-489c-a7ff-e8aa5fea6780",
                            CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f",
                            Date = new DateTime(2020, 2, 1, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 120,
                            ExamHall = 12318,
                            FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6",
                            Title = "Теоретична електротехника"
                        },
                        new
                        {
                            Id = "cdab35bc-fdb7-4811-803d-2cf305e78523",
                            CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f",
                            Date = new DateTime(2020, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = 120,
                            ExamHall = 4341,
                            FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6",
                            Title = "Електрически измервания"
                        },
                        new
                        {
                            Id = "32887b05-5e27-4cf6-9538-57d10d30640a",
                            CourseId = "41aee425-0155-42c0-a684-7b942c10a96a",
                            Date = new DateTime(2020, 1, 26, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 1152,
                            FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6",
                            Title = "Програмиране и използвнае на компютри 3"
                        },
                        new
                        {
                            Id = "e221588c-45f3-4807-9d15-9bc10ed731a2",
                            CourseId = "41aee425-0155-42c0-a684-7b942c10a96a",
                            Date = new DateTime(2020, 1, 21, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 60,
                            ExamHall = 10213,
                            FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6",
                            Title = "Полупроводникови елементи"
                        },
                        new
                        {
                            Id = "ac9b1767-b8c7-4e2e-88a9-b0df33c8d65f",
                            CourseId = "8ffa306b-e326-4752-9035-d060827f392d",
                            Date = new DateTime(2020, 1, 22, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 150,
                            ExamHall = 1154,
                            FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6",
                            Title = "Микропроцесорна техника"
                        },
                        new
                        {
                            Id = "08f2c18e-ed0d-48d5-8be7-a3f2d0e48018",
                            CourseId = "8ffa306b-e326-4752-9035-d060827f392d",
                            Date = new DateTime(2020, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = 120,
                            ExamHall = 2512,
                            FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6",
                            Title = "Транспортни телекомуникационни мрежи"
                        },
                        new
                        {
                            Id = "01926095-1133-4f6f-884b-c5dafd7abfe8",
                            CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c",
                            Date = new DateTime(2020, 1, 25, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 2130,
                            FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7",
                            Title = "Математика 1"
                        },
                        new
                        {
                            Id = "170409b5-70b9-41ef-8ec9-59618da4773c",
                            CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c",
                            Date = new DateTime(2020, 1, 29, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 2140,
                            FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7",
                            Title = "Физика 1"
                        },
                        new
                        {
                            Id = "7fc6ca56-f6d8-48d5-9e6e-725919dcec5c",
                            CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f",
                            Date = new DateTime(2020, 1, 27, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 2140,
                            FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7",
                            Title = "Математика 2"
                        },
                        new
                        {
                            Id = "5a48e827-c608-4064-958c-02b7dd72ebc9",
                            CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f",
                            Date = new DateTime(2020, 1, 23, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 90,
                            ExamHall = 3312,
                            FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7",
                            Title = "Машинознание 2"
                        },
                        new
                        {
                            Id = "016fb3f9-3895-4b19-93eb-0acf110fbbd5",
                            CourseId = "41aee425-0155-42c0-a684-7b942c10a96a",
                            Date = new DateTime(2020, 1, 24, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 120,
                            ExamHall = 3425,
                            FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7",
                            Title = "Производствени машини"
                        },
                        new
                        {
                            Id = "3aa4ff5d-d351-451f-8075-c6a30a5fc271",
                            CourseId = "41aee425-0155-42c0-a684-7b942c10a96a",
                            Date = new DateTime(2020, 1, 29, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            Duration = 150,
                            ExamHall = 4112,
                            FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7",
                            Title = "Производствени технологии 1"
                        },
                        new
                        {
                            Id = "d0a1ffac-4497-49cb-805e-bb4e3b79be5a",
                            CourseId = "8ffa306b-e326-4752-9035-d060827f392d",
                            Date = new DateTime(2020, 1, 28, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 180,
                            ExamHall = 4137,
                            FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7",
                            Title = "Програмиране на CNC машини"
                        },
                        new
                        {
                            Id = "e9060bbc-7a3a-44a2-9310-edb58be98f9b",
                            CourseId = "8ffa306b-e326-4752-9035-d060827f392d",
                            Date = new DateTime(2020, 1, 23, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            Duration = 90,
                            ExamHall = 3620,
                            FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7",
                            Title = "Управление на жизнения цикъл на изделията"
                        });
                });

            modelBuilder.Entity("TUExams.Data.Models.Faculty", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = "c8469f21-1cc6-4bc5-892e-933b5be61799",
                            Name = "Факултет по Компютърни Системи и Технологии"
                        },
                        new
                        {
                            Id = "054b0bce-5068-4788-83a3-b0a4828709a6",
                            Name = "Факултет по ТелеКомуникации"
                        },
                        new
                        {
                            Id = "462814e1-f72b-48cb-ab1a-3abe5663b9a7",
                            Name = "Машино-Технологичен Факултет"
                        });
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
