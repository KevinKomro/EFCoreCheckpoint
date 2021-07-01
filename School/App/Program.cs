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

            foreach (var c in query2)
            {
                System.Console.WriteLine("grade: " + c.grade);
            }

            Console.WriteLine("\r\nQuery 3");

        }
    }
}
