using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Max
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first no");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first no");
            int no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first no");
            int no3 = Convert.ToInt32(Console.ReadLine());

            if(no1>no2 && no1>no3)
            {
                Console.WriteLine(no1+":no is greater");
            }
            else if(no2>no3)
            {
                Console.WriteLine(no2+":no is greater");

            }
            else
            {
                Console.WriteLine(no3+":is greater");
            }
        }
    }
}
