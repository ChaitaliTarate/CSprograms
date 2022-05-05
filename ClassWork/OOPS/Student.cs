using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
    class Student
    {
        public string name;
        public int id;
        public int per;
        public string qualification;
        public static string t_name;
        public void settname(string tn)
        {
            t_name = tn;
        }

        public void accept()
        {
            Console.WriteLine("Enter the student name,id,percentage,qualification");
            name = Console.ReadLine();
            id = Convert.ToInt32(Console.ReadLine());
            per= Convert.ToInt32(Console.ReadLine());
            qualification= Console.ReadLine();

        }
        public void Display()
        {
            Console.WriteLine($"Name of student:{name}");
            Console.WriteLine($"id of student:{id}");
            Console.WriteLine($"percentage of student:{per}");
            Console.WriteLine($"Qualification of student:{qualification}");
        }

        static void Main(string[] args)
        {
            Student.t_name = "Deepa";
            Student s1 = new Student();
            s1.accept();
            s1.Display();
        }
    }
}
