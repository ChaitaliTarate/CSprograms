using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS2
{
   public class Order

    {
        int order;
        string orderdate;
      public Customer cust = new Customer();
        public Item it = new Item();
        public Order()
        {

        }
        public Order(int order,string orderdate,Customer cust,Item it)
        {
            this.order = order;
            this.orderdate = orderdate;
        }
        public void setOrder(int ord)
        {
            order = ord;            
        }
        public int getOrder()
        {
            return order;
        }

        public void setOrderdate(string date)
        {
            orderdate = date;
        }
        public string getOrderdate()
        {
            return orderdate;
        }

        public void setCust(Customer c)
        {
            cust = c;
        }
        public Customer getCust()
        {
            return cust;
        }

        public void setIt(Item i)
        {
            it = i;
        }
        public Item getIt()
        {
            return it;
        }
    } 
   public class Customer
    {
        int custid;
        string custname;
       public Address ad = new Address();

        public Customer()
        {

        }
        public Customer(int custid,string custname,Address ad)
        {
            this.custid = custid;
            this.custname = custname;
            this.ad = ad;
        }
       
        public void setCustid(int cid)
        {
            custid = cid;
        }
        public int getCustid()
        {
            return custid;
        }
        public void setCustname(string name)
        {
            custname = name;
        }
        public string getCustname()
        {
            return custname;
        }
        public void setAd(Address aa)
        {
            ad = aa;
        }
        public Address getAd()
        {
            return ad;
        }
    }
   public class Item
    {
        int itemid;
        string itemname;
        int price;

        public Item()
        {

        }
        public Item(int itemid,string itemname,int price)
        {
            this.itemid = itemid;
            this.itemname = itemname;
            this.price = price;
        }

        public void setItemid(int id)
        {
            itemid = id;
        }
        public int getItemid()
        {
            return itemid;
        }

        public void setItemname(string name)
        {
            itemname = name;
        }
        public string getItemname()
        {
            return itemname;
        }

        public void setPrice(int pri)
        {
            price = pri;
        }
        public int getPrice()
        {
            return price;
        }
    }

  public class Address
    {
        string add;
        string city;
        int pincode;

        public Address()
        {

        }
        public Address(string add, string city, int pincode)
        {
            this.add = add;
            this.city = city;
            this.pincode = pincode;
        }

        public void setAdd(string ad)
        {
            add = ad;
        }
        public string getAdd()
        {
            return add;
        }

        public void setcity(string ci)
        {
            city = ci;
        }
        public string getCity()
        {
            return city;
        }
        public void setPincode(int pin)

        {
            pincode = pin;
        }
        public int getPincode()
        {
            return pincode;
        }
    }

    class OrderTest
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();
            o1.setOrder(2);
            o1.setOrderdate("25 oct");
            o1.cust.setCustid(1);
            o1.cust.setCustname("pooja");
            o1.it.setItemid(11);
            o1.it.setItemname("pen");
            o1.it.setPrice(10);
            o1.cust.ad.setAdd("FCROAD");
            o1.cust.ad.setcity("pune");
            o1.cust.ad.setPincode(412210);

            Console.WriteLine("oreded:"+o1.getOrder());
            Console.WriteLine("Orderdate is:"+o1.getOrderdate());
            Console.WriteLine("Customer id is:"+o1.cust.getCustid());
            Console.WriteLine("Customer name is:"+o1.cust.getCustname());
            Console.WriteLine("Item id is:"+o1.it.getItemid());
            Console.WriteLine("Item name is:"+o1.it.getItemname());
            Console.WriteLine("Item price is:"+o1.it.getPrice());
            Console.WriteLine("Addrress is:"+o1.cust.ad.getAdd());
            Console.WriteLine("City is:"+o1.cust.ad.getCity());
            Console.WriteLine("pin code is:"+o1.cust.ad.getPincode());
        }
    }
}
