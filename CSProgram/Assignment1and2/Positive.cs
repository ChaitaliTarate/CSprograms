using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Positive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int no = Convert.ToInt32(Console.ReadLine());

            if(no>0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
