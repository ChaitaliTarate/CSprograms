using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class DivisibleBy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int no = Convert.ToInt32(Console.ReadLine());

            if(no%5==0 && no%11==0)
            {
                Console.WriteLine("No is divisible by 5 or 11");
            }
            else
            {
                Console.WriteLine("No is not divisible by 5 or 11");
            }
        }
    }
}
