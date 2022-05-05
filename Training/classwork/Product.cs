using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training.classwork
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }
    }


    
    class Program
    {
        static void Main(string[] args)
        {

      
        List<Product> productlist = new List<Product>()
        { 
        new Product{ Id=1,Name="Hp laptop", Price=35000},
        new Product{ Id=2,Name="Sony laptop", Price=45000},
        new Product{ Id=3,Name="Lenovo laptop", Price=30000},
        new Product{ Id=4 ,Name="Dell laptop", Price=50000},
        new Product{ Id=5,Name="Accer laptop", Price=50000},
         new Product{ Id=6,Name="Dell laptop", Price=55000},
        };

            /*var result = from p in productlist
                         where p.Name.StartsWith('H')
                         orderby p.Price

                         select p;*/

            var result = from p in productlist
                         where p.Name.Contains("Dell")
                         orderby p.Price descending

                         select p; 

            foreach (Product p in result)
            {
                Console.WriteLine($"{p.Name}  {p.Price}");
            }

    }

       
        
    }
}