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
            Seed();
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }


       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           


            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Exams)
                .WithOne(f => f.Faculty);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Exams)
                .WithOne(c => c.Course);
        }
        private void Seed()
        {
            if(this.Faculties.Count()!=3)
            {
                this.Faculties.Add(new Faculty { Name = "Факултет по Компютърни системи и технологии" });
                this.Faculties.Add(new Faculty { Name = "Факултет по Телекомуникации" });
                this.Faculties.Add(new Faculty { Name = "Машино-технологичен факултет" });
            }
            if(this.Courses.Count()!=4)
            {
                this.Courses.Add(new Course { Number = 1 });
                this.Courses.Add(new Course { Number = 2 });
                this.Courses.Add(new Course { Number = 3 });
                this.Courses.Add(new Course { Number = 4 });
            }

            SaveChanges();
        }
    }
}
