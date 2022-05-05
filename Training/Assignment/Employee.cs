using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Assignment
{
    class Employee
    {

        public int Id { get; set; }
        
        public string Name { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return $"Eid:{Id}  Ename{Name}    Salary{Salary}";
    }

        class Test
        {


            static void Main(string[] args)
            {
               
                
                Employee emp = new Employee()
                {
                    Id = 101,
                    Name = "Pooja",
                    Salary = 30000,

                };
                Employee emp2 = new Employee()
                {
                    Id = 102,
                    Name = "Sayali",
                    Salary = 20000,

                };

                Employee emp3 = new Employee()
                {
                    Id = 103,
                    Name = "Shubham",
                    Salary = 350000,

                };

                Stack<Employee> e1 = new Stack<Employee>();
                e1.Push(emp);
                e1.Push(emp2);
                e1.Push(emp3);

                foreach(Employee e in e1)
                {
                    Console.WriteLine(e);
                }

            }
        }
    }
}
