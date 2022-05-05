using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.loops
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range");
            int no = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for(int i=3;i<=no;i++)
            {
                int c = a + b;
                Console.WriteLine(c);
                a = b;
                 b = c;
            }
           
        }

    }
}
