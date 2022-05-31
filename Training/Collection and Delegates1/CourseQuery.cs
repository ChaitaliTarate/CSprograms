using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Training.Assignment
{
    class CourseQuery
    {
       
        public int Id { get; set; }
         public String Name { get; set; }
        public int Fees { get; set; }

    }

    class Program2
    {
        static void Main(string[] args)
        {


            List<CourseQuery> course = new List<CourseQuery>()
        {
        new CourseQuery {Id=101,Name="BSc",Fees=30000},
        new CourseQuery {Id=102,Name="MSc",Fees=60000},
        new CourseQuery {Id=103,Name="Bcom",Fees=10000},
        new CourseQuery {Id=104,Name="Engineering",Fees=90000},
        new CourseQuery {Id=105,Name="MBBS",Fees=90000},
        };
            // Query for cousre name start with M
            var result = from c in course
                         where c.Name.StartsWith('M')
                         select c;

            //Query for fees greater than 50000
            var result1 = from c in course
                          where c.Fees > 50000
                          orderby c.Fees
                          select c;


            //Query for Course name is MSc
            var result2=from c in course
                        where c.Name.Contains("MSc")
                        select c;

            //Query for Course name in ascending order
            var result3 = from c in course
                          orderby c.Fees ascending
                          select c;

            //Query for fees is between 50000 to 80000
            var result4 = from c in course
                          where c.Fees > 50000 && c.Fees < 80000
                          select c;

            //Query for showing details for course id is 101
            var result5 = from c in course
                          where c.Id == 101
                             select c;

            foreach (CourseQuery c in result5)
            {
                Console.WriteLine($"{c.Id}  {c.Name}  {c.Fees}");

            }


        }
    }
}
