using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Training.Assignment
{
    class StudentQuery
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
        public string Branch { set; get; }

    }

    class Program3
    {
        static void Main(string[] args)
        {


            List<StudentQuery> student = new List<StudentQuery>()
        {
            new StudentQuery{ RollNo=1,Name="Pooja",Percentage=88.20,Branch="Agri"},
            new StudentQuery{ RollNo=2,Name="Manish",Percentage=90.00,Branch="Science"},
             new StudentQuery{ RollNo=3,Name="Vaishnavi",Percentage=60,Branch="Commerce"},
              new StudentQuery{ RollNo=4,Name="Sarthak",Percentage=70.60,Branch="Engineering"},
               new StudentQuery{ RollNo=5,Name="Arti",Percentage=50,Branch="Arts"},
        };

            //Query for Showing details for scince branch
            var result = from s in student
                         where s.Branch.Contains("Science")
                         select s;


            //Query for showing details of student percetnage in ascending order
            var result1 = from s in student
                          orderby s.Percentage ascending
                          select s;


            //Showing details of student name is manish
            var result2 = from s in student
                          where s.Name.Contains("Manish")
                          select s;


            // showing details for rollno 5
            var result3 = from s in student
                          where s.RollNo == 5
                          select s;

            //Query for ascending order for name
            var result4 = from s in student
                          orderby s.Name ascending
                          select s;


            foreach(StudentQuery s in result4)
            {
                Console.WriteLine($"{s.RollNo}  {s.Name}  {s.Percentage}  {s.Branch}");
            }
        }
     }
}
