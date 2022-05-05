using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int no = Convert.ToInt32(Console.ReadLine());

            int digit = 0,sum=0,product=1;
            while(no>0)
            {
                digit = no % 10;
                sum = sum + digit;
                product = product * digit;
                no = no / 10;
            }
           if(sum==product)
            {
                Console.WriteLine("Spy");

            }
            else
            {
                Console.WriteLine("no");
            }
        }

    }
}
