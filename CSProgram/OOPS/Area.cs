using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.OOPS
{
    class Area
    {
       
       public void area(float pi,int rad)
        {
            float circlearea = pi * rad*rad;
            Console.WriteLine("Area of circle is:"+circlearea);
        }

        public void area(int length, int width)
        {
            float rectanglearea = length * width;
            Console.WriteLine("Area of rectangle is:" + rectanglearea);
        }

        public void area(int side)
        {
            float squareearea = side*side;
            Console.WriteLine("Area of square is:" + squareearea);
        }
        static void Main(string[] args)
        {
            Area a1 = new Area();
            Console.WriteLine("Enter the rad");
            int r = Convert.ToInt32(Console.ReadLine());
            float pi = 3.14f;
            a1.area(pi, r);

            Console.WriteLine("Enter length and width");
            int l = Convert.ToInt32(Console.ReadLine());
           int w= Convert.ToInt32(Console.ReadLine());
            a1.area(l, w);

            Console.WriteLine("Enter the side");
            int s=Convert.ToInt32(Console.ReadLine());
            a1.area(s);
        }

    }
}
