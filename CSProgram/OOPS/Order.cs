using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.OOPS
{
   public class Order
    {
        int orderid;
        String oredrdate;
        Customer cust = new Customer();
        Item i = new Item();

        public  Order()
        {

        }

        public Order(int orderid,string orderdate,Customer cust,Item i)
        {
            this.orderid = orderid;
            this.oredrdate = orderdate;
            this.cust = cust;
            this.i = i;
        }

        public int Orderid { get => orderid; set => orderid=value; }
        public string Orderdate { get => oredrdate; set => oredrdate = value; }

        public Customer Cust { get => cust; set => cust = value; }

        public Item It { get => i; set => i = value; }
    }

   public class Customer
    {
        string cname;
        Address ad = new Address();

        public Customer()
        {

        }

        public Customer(string cname, Address ad)
        {
            this.cname = cname;
            this.ad = ad;
        }

        public string Cname { get => cname; set => cname = value; }

        public Address Ad { get => ad; set => ad = value; }
    }

 public class Item
    {
        int ino;
        int price;
        
        public Item()
        {

        }

        public Item(int ino,int price)
        {
            this.ino=ino;
            this.price = price;
         }

        public int Ino { get => ino; set => ino = value; }
        public int Price { get => price; set => price = value; }
    }

   public class Address
    {
        string street;
        string city;

        public Address()
        {

        }
        public Address(string street,string city)
        {
            this.street = street;
            this.city = city;
        }

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
    }

    class OrderTest
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();
            o1.Orderid = 100;
            o1.Orderdate = "6 april";
            o1.Cust.Cname = "Shweta";
            o1.Cust.Ad.Street = "Fc Road";
            o1.Cust.Ad.City = "Pune";
            o1.It.Ino = 1;
            o1.It.Price = 400;

            Console.WriteLine("Order id is:"+o1.Orderid);
            Console.WriteLine("Orderdate is:"+o1.Orderdate);
            Console.WriteLine("Customr name is:"+o1.Cust.Cname);
            Console.WriteLine("Address street is:"+o1.Cust.Ad.Street);
            Console.WriteLine("City is:"+o1.Cust.Ad.City);
            Console.WriteLine("Item no is:"+o1.It.Ino);
            Console.WriteLine("item price is:"+o1.It.Price);

            Console.WriteLine();

            Item i1 = new Item(2,500);

            Address a1 = new Address("Karve Road","Pune");

            Customer c1 = new Customer("Chaitali", a1);

            Order o2 = new Order(200, "7 april",c1,i1);

            Console.WriteLine("Order id is:"+o2.Orderid);
            Console.WriteLine("Orderdate is:"+o2.Orderdate);
            Console.WriteLine("Customr name is:"+o2.Cust.Cname);
            Console.WriteLine("Address street is:"+o2.Cust.Ad.Street);
            Console.WriteLine("City is:"+o2.Cust.Ad.City);
            Console.WriteLine("Item no is:"+o2.It.Ino);
            Console.WriteLine("item price is:"+o2.It.Price);

        }
    }
}
