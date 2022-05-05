using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
    class Flat
    {
        int flatno;
        string buildingname;
        Member mem=new Member();

        public Flat()
        {

        }

        public Flat(int flatno,string buildingname,Member mem)
        {
            this.flatno = flatno;
            this.buildingname = buildingname;
           this.mem = mem;
        }
            
        public int Flatno { get => flatno; set => flatno = value; }
        public string Buildingname { get=> buildingname; set=> buildingname=value; }
        
       public Member Mem { get => mem; set => mem = value; }

    }



    class Member
    {
        string membername;
        char gender;
        int age;
        string profession;

        public Member()
        {

        }

        public Member(string membername,char gender,int age,string profession)
        {
            this.membername = membername;
            this.gender = gender;
            this.age = age;
            this.profession = profession;
        }
        public string Membername
        {
            set { membername = value; }
            get { return membername; }
        }

        public char Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public string Proffession { get => profession; set => profession= value; }
    }
    class FlatTest
    {
        static void Main(string[] args)
        {
            Flat f = new Flat();
            
            f.Flatno = 101;
            f.Buildingname = "ABC";
            f.Mem.Membername = "XYZ";
            f.Mem.Age = 30;
            f.Mem.Gender = 'F';
            f.Mem.Proffession = "Teacher";

            Console.WriteLine("flat no is:"+f.Flatno);
            Console.WriteLine("Building name is;"+f.Buildingname);
            Console.WriteLine("Member name is:"+f.Mem.Membername);
            Console.WriteLine("Age is;" + f.Mem.Age);
            Console.WriteLine("Gender is:" + f.Mem.Gender);
            Console.WriteLine("Proffession is:"+f.Mem.Proffession);
            Console.WriteLine();
            Member m2 = new Member("chaitali", 'f', 22, "Student");
            Flat f2 = new Flat(102, "lmn", m2);
            Console.WriteLine("flat no is:" + f2.Flatno);
            Console.WriteLine("Building name is;" + f2.Buildingname);
            Console.WriteLine("Member name is:" + f2.Mem.Membername);
            Console.WriteLine("Age is;" + f2.Mem.Age);
            Console.WriteLine("Gender is:" + f2.Mem.Gender);
            Console.WriteLine("Proffession is:" + f2.Mem.Proffession);
        }
    }
}
