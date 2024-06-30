using System;
using System.Collections.Generic;

namespace Apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //Okul otomasyonu 
    //Student,Teacher,Lesson,Exam...

    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public DateTime BirthDate { get; set; }
        public Teacher Teacher { get; set; } //Navigation Property 
        public List<Lesson> Lessons { get; set; }//Navigation Property 
        public School School { get; set; }//Navigation Property 
    }



    //[] -> List 

    public class Teacher
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

    }

    public class Lesson
    {
        public string Code { get; set; }
        public string Name { get; set; }

    }

    public class School
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
