using System;
using System.Collections.Generic;

namespace App
{
    public class Grades
    {
        public int Id { get; set;}
        public int StudentId { get; set; }
        public string CourseName { get; set; }
        public double Grade { get; set; }
        public Student Student { get; set;}
    }
}