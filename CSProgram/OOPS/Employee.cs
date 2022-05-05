using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.OOPS
{
    class Employee
    {
        int id;
        string name;
        float salary;

        public void setId(int i)
        {
            id = i;
        }
        public int getId()
        {
            return id;
        }

        public void setName(string n)
        {
            name = n;
        }
        public string getName()
        {
            return name;
        }

        public void setSalary(float sal)
        {
            salary = sal;
        }

        public float getSalary()
        {
            return salary;
        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Enter eid");
            int e = Convert.ToInt32(Console.ReadLine());
            e1.setId(e);


            Console.WriteLine("Enter name:");
            string n =Console.ReadLine();
            e1.setName(n);

            Console.WriteLine("Enter salary:");
            float s = Convert.ToSingle(Console.ReadLine());
            e1.setSalary(s);

            Console.WriteLine("Employee id is:"+ e1.getId());
            Console.WriteLine("Employyee name is:"+e1.getName());
            Console.WriteLine("Employye salary is:"+e1.getSalary());
        }
    }
}
