using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int no=Convert.ToInt32(Console.ReadLine());
        
            if(no%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

    }
}
