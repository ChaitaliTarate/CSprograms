using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS2
{
    class Person
    {
        int id;
        string pname;
        Vehicle v = new Vehicle();

        public Person()
        {

        }

        public Person(int id,string pname)
        {
            this.id = id;
            this.pname = pname;
         }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
    public string Pname
        {
            set { pname = value; }
            get { return pname; }
        }

        public Vehicle V
        {
            set { v = value; }
            get { return v; }
        }
   
        }

    class Vehicle
    {
        int vid;
        string name;

        public Vehicle()
        {

        }
        public Vehicle(int vid,string name)
        {
                this.vid = vid;
            this.name = name;
        }
        
        public int Vid
        {
            set { vid = value; }
            get { return vid; }
        }

       /* public string Name
        {
            set { name = value; }
            get { return name; }
        }
       */
        public void setName(string n)
        {
            name = n;
        }
        public string getName()
        {
            return name;
        }
    }

    class PersonTest
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            Console.WriteLine("Enter the person id");
            int i = Convert.ToInt32(Console.ReadLine());
            p1.Id = i;

            Console.WriteLine("Enter name of Person");
            string n = Console.ReadLine();
            p1.Pname = n;

         

            Console.WriteLine("Enter the vehicl id");
            int vi= Convert.ToInt32(Console.ReadLine());
            p1.V.Vid=vi;

            Console.WriteLine("Enter the vehicle name");
            string vn = Console.ReadLine();
           p1.V.setName(vn);

            Console.WriteLine("person name is:"+p1.Pname);
            Console.WriteLine("Person id is:"+p1.Id);
            Console.WriteLine("Vehicle id is:"+p1.V.Vid);
            Console.WriteLine("Vihicle name is:"+p1.V.getName());
        }   
    }
}
