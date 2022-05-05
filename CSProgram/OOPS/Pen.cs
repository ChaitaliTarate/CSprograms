using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.OOPS
{
    class Pen
    {

        string penbrand;
        string pencolor;
        int price;

        public void setBrand(string brand)
        {
            penbrand = brand;
        }
        public string getBrand()
        {
            return penbrand;
        }

        public void setColor(string color)
        {
            pencolor = color;
        }

        public string getColor()
        {
            return pencolor;
        }

        public void setPrice(int pri)
        {
            price = pri;
        }

        public int getPrice()
        {
            return price;
        }

        static void Main(string[] args)
        {
            Pen p1 = new Pen();

            Console.WriteLine("Enter the brand name");
            string b = Console.ReadLine();
            p1.setBrand(b);

            Console.WriteLine("color of the pen is:");
            string c = Console.ReadLine();
            p1.setColor(c);

            Console.WriteLine("price of the pen:");
            int p = Convert.ToInt32(Console.ReadLine());
            p1.setPrice(p);

            Console.WriteLine("Pen brand is:" + p1.getBrand());
                Console.WriteLine("pen color is:"+p1.getColor());
            Console.WriteLine("pen price is:"+p1.getPrice());



        }
    }
}
