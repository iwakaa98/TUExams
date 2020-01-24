using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TUExams.Data.Models;

namespace TUExams.Data
{
    public class TUExamContext : DbContext
    {
        public TUExamContext(DbContextOptions<TUExamContext> options) : base(options)
        {
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Exams)
                .WithOne(f => f.Faculty);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Exams)
                .WithOne(c => c.Course);


                Seed(modelBuilder);


        }
        private static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Faculty>()
                .HasData(
                new Faculty { Id = "c8469f21-1cc6-4bc5-892e-933b5be61799", Name = "Факултет по Компютърни Системи и Технологии" },
                new Faculty { Id = "054b0bce-5068-4788-83a3-b0a4828709a6", Name = "Факултет по ТелеКомуникации" },
                new Faculty { Id = "462814e1-f72b-48cb-ab1a-3abe5663b9a7", Name = "Машино-Технологичен Факултет" });

            modelBuilder.Entity<Course>()
                .HasData(
                new Course { Id = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", Number = 1 },
                new Course { Id = "d2d35048-1d12-4621-82d1-5529d7563c2f", Number = 2 },
                new Course { Id = "41aee425-0155-42c0-a684-7b942c10a96a", Number = 3 },
                new Course { Id = "8ffa306b-e326-4752-9035-d060827f392d", Number = 4 });

            modelBuilder.Entity<Exam>()
                .HasData(
                    // ФКСТ изпити
                    new Exam { Id = "55f7dc5f-c803-42ab-8ea6-73828fb71182", CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799", Duration = 180, Title = "Физика 1 ", Date = new DateTime(2020, 1, 23, 15, 30, 0),ExamHall=1152 },
                    new Exam { Id = "48619be3-aba2-4159-aef5-c9ebef9983f8", CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799", Duration = 180, Title = "Математика 1 ", Date = new DateTime(2020, 1, 29, 11, 30, 0), ExamHall = 1153 },
                    new Exam { Id = "bde0cb83-2136-40f1-b592-3276c57e9284", CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f", FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799", Duration = 90, Title = "Химия ", Date = new DateTime(2020, 1, 29, 11, 30, 0), ExamHall = 1154 },
                    new Exam { Id = "2c8fa666-c8d9-495d-b116-efb61672eeb1", CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f", FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799", Duration = 180, Title = "Математика 3", Date = new DateTime(2020, 1, 24, 8, 0, 0), ExamHall = 2130 },
                    new Exam { Id = "a905c64f-f2f6-43b2-9e04-0fc118e86be8", CourseId = "41aee425-0155-42c0-a684-7b942c10a96a", FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799", Duration = 90, Title = "Програмиране и използване на компютри 2", Date = new DateTime(2020, 1, 27, 11, 30, 0), ExamHall = 12152 },
                    new Exam { Id = "3b1028c0-0ef4-48ed-b748-881a6b218a32", CourseId = "41aee425-0155-42c0-a684-7b942c10a96a", FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799", Duration = 180, Title = "Физика 2", Date = new DateTime(2020, 1, 23, 15, 30, 0), ExamHall = 2140 },
                    new Exam { Id = "43bfdfb5-83d3-466f-be29-622962619744", CourseId = "8ffa306b-e326-4752-9035-d060827f392d", FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799", Duration = 120, Title = "Бази от Данни", Date = new DateTime(2020, 1, 27, 11, 30, 0), ExamHall = 2130 },
                    new Exam { Id = "0865d346-69fe-4866-8fe2-1f9611a84fe2", CourseId = "8ffa306b-e326-4752-9035-d060827f392d", FacultyId = "c8469f21-1cc6-4bc5-892e-933b5be61799", Duration = 90, Title = "Програмиране и използване на компютри 3", Date = new DateTime(2020, 1, 24, 8, 0, 0), ExamHall = 1152 },
                    //ФТК изпити
                    new Exam { Id = "8fecb0b9-c0e3-418d-9243-60173db9b187", CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6", Duration = 180, Title = "Физика 1 ", Date = new DateTime(2020, 1, 24, 11, 30, 0), ExamHall = 2130 },
                    new Exam { Id = "785a291d-b4c3-42f3-a949-c09b8f676719", CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6", Duration = 180, Title = "Математика  1 ", Date = new DateTime(2020, 1, 29, 15, 30, 0), ExamHall = 2140 },
                    new Exam { Id = "21a11635-216a-489c-a7ff-e8aa5fea6780", CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f", FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6", Duration = 120, Title = "Теоретична електротехника", Date = new DateTime(2020, 2, 1, 11, 30, 0), ExamHall = 12318 },
                    new Exam { Id = "cdab35bc-fdb7-4811-803d-2cf305e78523", CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f", FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6", Duration = 120, Title = "Електрически измервания", Date = new DateTime(2020, 1, 25, 8, 0, 0), ExamHall = 4341 },
                    new Exam { Id = "32887b05-5e27-4cf6-9538-57d10d30640a", CourseId = "41aee425-0155-42c0-a684-7b942c10a96a", FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6", Duration = 180, Title = "Програмиране и използвнае на компютри 3", Date = new DateTime(2020, 1, 26, 8, 0, 0), ExamHall = 1152 },
                    new Exam { Id = "e221588c-45f3-4807-9d15-9bc10ed731a2", CourseId = "41aee425-0155-42c0-a684-7b942c10a96a", FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6", Duration = 60, Title = "Полупроводникови елементи", Date = new DateTime(2020, 1, 21, 15, 30, 0), ExamHall = 10213 },
                    new Exam { Id = "ac9b1767-b8c7-4e2e-88a9-b0df33c8d65f", CourseId = "8ffa306b-e326-4752-9035-d060827f392d", FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6", Duration = 150, Title = "Микропроцесорна техника", Date = new DateTime(2020, 1, 22, 11, 30, 0), ExamHall = 1154 },
                    new Exam { Id = "08f2c18e-ed0d-48d5-8be7-a3f2d0e48018", CourseId = "8ffa306b-e326-4752-9035-d060827f392d", FacultyId = "054b0bce-5068-4788-83a3-b0a4828709a6", Duration = 120, Title = "Транспортни телекомуникационни мрежи", Date = new DateTime(2020, 1, 29, 8, 0, 0), ExamHall = 2512 },
                    // МТФ изпити
                    new Exam { Id = "01926095-1133-4f6f-884b-c5dafd7abfe8", CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7", Duration = 180, Title = "Математика 1", Date = new DateTime(2020, 1, 25, 8, 0, 0), ExamHall = 2130 },
                    new Exam { Id = "170409b5-70b9-41ef-8ec9-59618da4773c", CourseId = "bc84d656-ddd4-42a0-a767-2d3dc59bc10c", FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7", Duration = 180, Title = "Физика 1", Date = new DateTime(2020, 1, 29, 11, 30, 0), ExamHall = 2140},
                    new Exam { Id = "7fc6ca56-f6d8-48d5-9e6e-725919dcec5c", CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f", FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7", Duration = 180, Title = "Математика 2", Date = new DateTime(2020, 1, 27, 11, 30, 0), ExamHall = 2140 },
                    new Exam { Id = "5a48e827-c608-4064-958c-02b7dd72ebc9", CourseId = "d2d35048-1d12-4621-82d1-5529d7563c2f", FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7", Duration = 90, Title = "Машинознание 2", Date = new DateTime(2020, 1, 23, 15, 30, 0), ExamHall = 3312 },
                    new Exam { Id = "016fb3f9-3895-4b19-93eb-0acf110fbbd5", CourseId = "41aee425-0155-42c0-a684-7b942c10a96a", FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7", Duration = 120, Title = "Производствени машини", Date = new DateTime(2020, 1, 24, 11, 30, 0), ExamHall = 3425 },
                    new Exam { Id = "3aa4ff5d-d351-451f-8075-c6a30a5fc271", CourseId = "41aee425-0155-42c0-a684-7b942c10a96a", FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7", Duration = 150, Title = "Производствени технологии 1", Date = new DateTime(2020, 1, 29, 8, 0, 0), ExamHall = 4112 },
                    new Exam { Id = "d0a1ffac-4497-49cb-805e-bb4e3b79be5a", CourseId = "8ffa306b-e326-4752-9035-d060827f392d", FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7", Duration = 180, Title = "Програмиране на CNC машини", Date = new DateTime(2020, 1, 28, 11, 30, 0), ExamHall = 4137 },
                    new Exam { Id = "e9060bbc-7a3a-44a2-9310-edb58be98f9b", CourseId = "8ffa306b-e326-4752-9035-d060827f392d", FacultyId = "462814e1-f72b-48cb-ab1a-3abe5663b9a7", Duration = 90, Title = "Управление на жизнения цикъл на изделията", Date = new DateTime(2020, 1, 23, 15, 30, 0), ExamHall = 3620 });
        }
    }
}
