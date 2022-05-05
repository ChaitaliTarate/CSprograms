using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Assign2pro15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int no = Convert.ToInt32(Console.ReadLine());
            int fact = 1;

            for(int i=1;i<=no;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
