using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS2
{
    class Teacher
    {
        int tid;
        string tname;
        long mono;

        public Teacher()
        {

        }
        public Teacher(int tid,string tname,long mono)
        {
            this.tid = tid;
            this.tname = tname;
            this.mono = mono;

        }

        public int Tid
        {
          set { tid = value; }
            get { return tid; }

        }

        public string Tname
        {
            set { tname = value; }
            get { return tname; }
        }

        public long Mono
        {
            set { mono = value; }
            get { return mono; }
        }
    }
    class Hourlybased : Teacher
    {
        int rateph;
        int hours;
        public Hourlybased()
        {

        }
        public Hourlybased(int tid,string tname,long mono,int rateph,int hours):base(tid,tname,mono)
        {
            this.rateph = rateph;
            this.hours = hours;
        }

        void Salary()
        {
            int salary = hours * rateph;
            Console.WriteLine(salary);
        }
    }

    class Salarybased:Teacher
    {
        int salary;

        public Salarybased(int salary,int tid,long mono)
        {
            this.salary = salary;

        }
        void Salary()
        {
            
            Console.WriteLine("Salary"+salary);
        }
    }


    class TeacherTest
    {
        static void Main(string[] args)
        {

            Teacher t1 = new Teacher(1,"deepa",3021589632);
            Hourlybased h1 = new Hourlybased(1,"deepa", 3021589632,3200,5);
            Salarybased s1 = new Salarybased(50000,1, 3021589632);
           
           

        }
    }
}
