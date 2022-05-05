using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS2
{
    class Volume
    {

        public double Vol(double r)
        {
            double v;
            v = 4 / 3 * 22 / 7 * r;
            return v;
        }

        public double Vol(double h, double r)
        {
            double v;
            v = 22 / 7 * r * h;
            return v;
        }

        public double Vol(double l,double b,double h)
        {
            double v;
            v = l * b * h;
            return v;
        }
        static void Main(string[] args)
        {
            Volume v1 = new Volume();
            double volume1=v1.Vol(2);
           double volume2= v1.Vol(5, 2);
           double volume3= v1.Vol(1, 3, 4);

            Console.WriteLine(volume1);
            Console.WriteLine(volume2);
            Console.WriteLine(volume3);
        }

    }
}
