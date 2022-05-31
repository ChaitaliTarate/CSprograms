using System;
using System.Collections.Generic;
using System.Text;

namespace Training.classwork
{
    class Student
    {
        
        public string Name { get; set; }

        public string City { get; set; }
    }
    class Course
    {

        public String Cname { get; set; }
        public int Fees { get; set; }

        // public Student Students { get; set; }
        public List<Student> Students = new List<Student>();

    }

    class Test
    {
        static void Main(string[] args)
        {


            List<Course> courses = new List<Course>()
        {
            new Course{ Cname="C#",Fees=5000,Students={
                new Student{ Name="chaitali",City="Pune"},
                 new Student{ Name="pooja",City="nagar"},
                }
            

        },
            new Course
            {
                Cname = "java", Fees = 6000,Students ={
                new Student{ Name="shubham",City="nagar"},
                 new Student{ Name="pooja",City="nagar"},
                }
            }

};
        }
    }
}