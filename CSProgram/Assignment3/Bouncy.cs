using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Bouncy
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 2 number");
            int a = Convert.ToInt32(Console.ReadLine());

            bool isincrease = true;
            bool isdcrease = true;
            int next = a % 10;
            a=a/10;

            while(a>0)
            {
                int prev = a % 10;
                if(prev>next)
                {
                    isincrease = false;
                }
                if(prev<next)
                {
                    isdcrease = false;
                }
                a = a / 10;
                next = prev;
            }
            if(isincrease)
                Console.WriteLine("increasing");
            else if(isdcrease)
                Console.WriteLine("decreasing");
            else
                Console.WriteLine("bouncy");
        }
    }
}
