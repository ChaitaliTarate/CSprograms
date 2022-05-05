using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base:");
            int b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the exponent:");
            int exp = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int power = 1;

            while(i<=exp)
            {
                power = power * b;
                i++;
            }
            Console.WriteLine(power);
        }
    }
}
