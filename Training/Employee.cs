using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public int CompareTo(object obj)
        {
            Employee e2 = (Employee)obj;
            if (this.Salary > e2.Salary)
                return 1;
            else
                return 0;

        }
    }

    class Emp
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Id = 1, Name = "chaitali", Salary = 4000 };
            Employee e2 = new Employee { Id = 2, Name = "abc", Salary = 3000 };
            int result = e1.CompareTo(e2);
            if (result == 1)
            {
                Console.WriteLine($"Salary of {e1.Name} employee is greater");
            }
            else
            {
                Console.WriteLine($"Salary of {e2.Name} employee is greater");
            }

        }
    }



    public class Employee1
    {


        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }

    }
    class Test
    {


        static void Main(string[] args)
        {
            List<Employee1> list1 = new List<Employee1>()
            {
            new Employee1 { Id = 1, Name = "pooja", Salary = 35000 },
            new Employee1 { Id = 2, Name = "shweta", Salary = 25000 },


        };

            foreach (Employee1 a in list1)
            {
                Console.WriteLine($"id is:{a.Id}   name is:{a.Name}  salary is:{a.Salary}");
            }




        }
    


    }
}
