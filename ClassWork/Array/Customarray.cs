using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Array
{

    class Student
    {
        string nm;
        int per;
        public Student()
        {

        }
        public Student(string nm,int per)
        {
            this.nm = nm;
            this.per = per;
          
        }

        public override string ToString()
        {
            return $"Name:{nm} percentagr:{per}";
        }
    }
    class StudentTest
    {
        
        static void Main(string[] args)
        {
            string nm;
            int per;
            Student[] sarr = new Student[5];
            
            for(int i=0;i<sarr.Length;i++)
            {
                Console.WriteLine("Enter name, percent");
                nm = Console.ReadLine();
                per = int.Parse(Console.ReadLine());
                sarr[i] = new Student(nm,per);
            }

            for (int i = 0; i < sarr.Length; i++)
            {
                Console.WriteLine(sarr[i] + "" + sarr[i]);
            }

            }
    }
}
