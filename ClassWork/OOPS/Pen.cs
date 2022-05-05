using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
   public class Pen
    {
        int penprice;
        string brand;
       public  Refil refe=new Refil();

        public Pen()
        {

        }
        public Pen(int penprice,string brand,Refil refe)
        {
            this.penprice = penprice;
            this.brand = brand;
            this.refe= refe;
        }

        public int Penprice
        {
            set { penprice = value; }
            get { return penprice; }
        }

        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
        public Refil Refe
        {
            set { refe = value; }
            get { return refe; }
        }
    }

    public class Refil
    {
        string color;
   public Nipp n = new Nipp();
        public Refil()
        {

        }
        public Refil(string color, Nipp n)
        {
            this.color = color;
            this.n = n;
        }
        public string Color
        {
            set { color = value; }
            get { return color; }
        }

       public Nipp N
        {
            set { n = value; }
            get { return n; }

        }
    }


    public class Nipp
    {
        string type;
        public Nipp()
        {

        }
        public Nipp(string type)
        {
            this.type = type;

        }

        public string Type
        {
            set { type = value; }
            get { return type; }
        }
    }
    class TestPenn
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.Penprice=50;
            p1.Brand = "Trimax";
            p1.Refe.Color = "Blue";
            p1.Refe.N.Type = "Sharp";


            Console.WriteLine("Pen price is:"+p1.Penprice);
            Console.WriteLine("Pen Brand is:"+p1.Brand);
            Console.WriteLine("Pen Color is:"+p1.Refe.Color);
            Console.WriteLine("Pen Type is:"+p1.Refe.N.Type);
        }
    }
}
