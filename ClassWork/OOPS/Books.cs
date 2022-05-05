using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
    class Books
    {
        public string Bname;
        public string Bauthor;
        public int Bid;
        public int price;

    }


    class BookTest
        {

        static void Main(string[] args)
         {
            Books b1 = new Books();
            b1.Bname="Agnipankh";
            b1.Bauthor = "Abdul Kalam";
            b1.Bid = 1;
            b1.price = 400;
            Console.WriteLine($"Book name:{b1.Bname} Book Author:{b1.Bauthor} Book id:{b1.Bid} Book Price:{b1.price}");


            Books b2 = new Books();
            Console.WriteLine("Enter Book name,book author book id,book price");

            b2.Bname = Console.ReadLine();
            b2.Bauthor = Console.ReadLine();
            b2.Bid = Convert.ToInt32(Console.ReadLine());
            b2.price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Book name:{b2.Bname} Book Author:{b2.Bauthor} Book id:{b2.Bid} Book Price:{b2.price}");
        }
    }
}
