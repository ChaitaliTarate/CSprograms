using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
   internal class Calci
    {
       public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public float SimpleInterest(int p,float r,int n)
        {
            float res = p * r * n;
            return res;
        }

        public bool LeapYear( int yy)
        {
            if(yy%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            Calci c1 = new Calci();
           int add= c1.Add(10, 20);
            Console.WriteLine(add);

           float Cal= c1.SimpleInterest(10, 10.12f, 5);
            Console.WriteLine(Cal);

            bool leap = c1.LeapYear(2020);

            Console.WriteLine(leap);
        }
    }
}
