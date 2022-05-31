using System;
using System.Collections.Generic;
using System.Text;

namespace Training.classwork
{
    

    class Employee
    {
        public int Id { get; set; }

        public string Ename { set; get; }

       
    }

    class Department
    {
        public int Did { get; set; }
        public string Dame { get; set; }

        public List<Employee> Emp = new List<Employee>();
    }

    class Test1
    {
        static void Main(string[] args)
        {
            List<Department> DList = new List<Department>()
            {
                new Department{Did=101,Dame="CS",Emp={
                    new Employee{ Id=10,Ename="pooja"},
                     new Employee{ Id=20,Ename="sayali"},

                    }
            },

            new Department{Did=102,Dame="Commerce",Emp={
                    new Employee{ Id=30,Ename="manish"},
                     new Employee{ Id=40,Ename="shubham"},

                    }
            }

        };


            foreach(Department d in DList)
            {
                Console.WriteLine(d.Dame);
                foreach(Employee e in  d.Emp)
                {
                    Console.WriteLine($"{e.Id}    {e.Ename}");
                }
            }
        }
    }
}
