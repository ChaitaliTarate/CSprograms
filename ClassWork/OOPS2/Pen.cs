using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS2
{
    class Pen
    {
        string penbrand;
        int pencaplength;
      public Refill refe = new Refill();
        

        public Pen()
        {

        }

        public Pen(string brand,int caplength,Refill refee)
        {
            this.penbrand = brand;
            this.pencaplength = caplength;
            this.refe = refee;
        }

        public void setPenBrand(string brand)
        {
            penbrand = brand;
        }

        public string getBrand()
        {
            return penbrand;
        }

        public void setPenCaplength(int caplength)
        {
            pencaplength = caplength;
        }
        public int getPenCaplength()
        {
            return pencaplength;
        }

        public void setRefill(Refill refee)
        {
            refe = refee;
        }
        public Refill getRefill()
        {
            return refe;
        }
    }



    class Refill
    {
        string inkColor;
        int length;
         public Nib n = new Nib();

        public Refill()
        {

        }
        public Refill(string inkcolor,int length,Nib n)
        {
            this.inkColor = inkcolor;
            this.length = length;
            this.n = n;
        }
        public void setInkcolor(string color)
        {
            inkColor = color;
        }

        public string getInkcolor()
        {
            return inkColor;
        }

        public void setLength(int l)
        {
            length = l;
        }
        public int getLength()
        {
            return length;
        }
        public void setN(Nib nn)
        {
            n = nn;
        }
        public Nib getN()
        {
            return n;
        }
    }

    class Nib
    {
        string mtype;
        int width;
      public  Nib()
        {

        }
        public Nib(string mtype,int width)
        {
            this.mtype = mtype;
            this.width = width;
        }

        public void setMtype(string type)
        {
            mtype = type;
        }
        public string getMtyope()
        {
            return mtype;
        }
        public void setWidth(int w)
        {
            width = w;
        }
        public int getWidth()
        {
            return width;
        }
    }

    class PenTest
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.setPenBrand("Cello");
            p1.setPenCaplength(1);
            p1.refe.setInkcolor("Blue");
            p1.refe.setLength(5);
            p1.refe.n.setMtype("Sharp");
            p1.refe.n.setWidth(5);

            

            Console.WriteLine("pen name is:"+p1.getBrand());
            Console.WriteLine("Pen cap length is:"+p1.getPenCaplength());
            Console.WriteLine("Refil color is:"+p1.refe.getInkcolor());
            Console.WriteLine("refil length is:"+p1.refe.getLength());
            Console.WriteLine("Material type is:"+p1.refe.n.getMtyope());
            Console.WriteLine("Width is:"+p1.refe.n.getWidth());

        }
    }
}
