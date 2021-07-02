using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var database = new DataContext();

            /* Console.WriteLine("Inserting class for Buzz");
            var newClass = new List<Grades>{new Grades {Id=4, StudentId = 1, CourseName = "Compsci 1240", Grade = .95} };
            database.AddRange(newClass);
            database.SaveChanges(); */

            /* var grades = database.Grades.ToList();

            foreach (Grades grade in grades)
            {
                Console.WriteLine($"{grade.Id} : {grade.StudentId} : {grade.CourseName} : {grade.Grade}");
            } */

            Console.WriteLine("\r\nQuery 1");
            var students = database.Students.ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id} : {student.FirstName} : {student.LastName} : {student.Age} : {student.Year}");
            }

            Console.WriteLine("\r\nQuery 2");

            var query2 = from c in database.Students
                         join a in database.Grades
                         on c.Id equals a.StudentId
                         where c.FirstName.Contains("Buzz")
                         select new
                         {
                             grade = a.Grade
                         };

            query2.ToList().ForEach(obj => Console.WriteLine($"grade : {obj.grade}"));

            Console.WriteLine("\r\nQuery 3");

            var query3 = (from c in database.Students join a in database.Grades
                                                      on c.Id equals a.StudentId 
                                                      where c.FirstName.Contains("Buzz")
                                                      select a.Grade).Average();

            Console.WriteLine($"average is: " + query3);

            Console.WriteLine("\r\nQuery 4");

            var query4 = from c in database.Students join a in database.Grades
                                                      on c.Id equals a.StudentId 
                                                      group a by new {
                                                          a.Grade
                                                      } into g
                                                      select new {
                                                          Average = g.Average(p => p.Grade)
                                                      };

            query4.ToList().ForEach(obj => Console.WriteLine($"average : {obj.Average}"));

        }
    }
}
