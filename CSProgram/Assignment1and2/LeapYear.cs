using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());

            if(year%4==0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("not Leap Year");
            }
        }
    }
}
