using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Training.classwork
{
    class Emp
    {
       
            public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
        public string Dept { get; set; }
    }

   
    class Program1
    {
        static void Main(string[] args)
        {

            List<Emp> emp = new List<Emp>()
            {
                new Emp{Id=1,Name="Pooja",City="Nagar",Salary=25000,Dept="Account"},
                new Emp{Id=2,Name="manish",City="mumbai",Salary=50000,Dept="production"},
                new Emp{Id=3,Name="chaitali",City="pune",Salary=35000,Dept="Developer"},
                new Emp{Id=4,Name="sayali",City="pune",Salary=25000,Dept="Developer"},
                new Emp{Id=5,Name="shubham",City="mumbai",Salary=55000,Dept="testing"},
                new Emp{Id=6,Name="shivani",City="satara",Salary=22000,Dept="sales"},
                new Emp{Id=7,Name="Sampada",City="Nagar",Salary=45000,Dept="HR"},
            };

            /*var result = from e in emp
                         where e.Salary>45000
                         
                         select e;*/

            /* var result = from e in emp
                          orderby e.Name ascending

                          select e;*/


            /* var result = from e in emp
                          where e.City.Contains("mumbai")

                          select e;*/

            /* var result = from e in emp
                          where e.Dept.Contains("HR")

                          select e;*/

            /*var result = from e in emp
                         orderby e.Salary descending

                         select e;
*/
            /*var result = from e in emp
                         where e.Name.StartsWith('K') || e.Name.StartsWith('A')

                         select e;*/
            var result = from e in emp
                         where e.City.Contains("pune") && e.Salary<35000

                         select e; 

            foreach (Emp e in result)
            {
                Console.WriteLine($"{e.Id}  {e.Name}  {e.City}  {e.Salary}  {e.Dept}");
            }

        }
    }

}
   

