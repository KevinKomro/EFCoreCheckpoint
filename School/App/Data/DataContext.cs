using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App
{
    public class DataContext : DbContext
    {
        public DbSet<Grades> Grades { get; set;}
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=app.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            var students = new Student[] {
                new Student {Id=1, FirstName="Buzz", LastName="Liteya", Age=19, Year=App.Student.Classification.Freshman.ToString()},
                new Student {Id=2, FirstName="Rick", LastName="Ziggler", Age=23, Year=App.Student.Classification.Senior.ToString()},
                new Student {Id=3, FirstName="Sheila", LastName="Jinkees", Age=21, Year=App.Student.Classification.Junior.ToString()},
            };

            modelBuilder.Entity<Student>().HasData(students);
            
            var grades = new Grades [] {
                new Grades {Id=1, StudentId=1, CourseName="Science 233", Grade=0.87},
                new Grades {Id=2, StudentId=2, CourseName="Math 303", Grade=0.65},
                new Grades {Id=3, StudentId=3, CourseName="History 102", Grade=0.99},
            };

            modelBuilder.Entity<Grades>().HasData(grades);

            base.OnModelCreating(modelBuilder);
        }

    }
}