using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Assign2pro10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int no = Convert.ToInt32(Console.ReadLine());
            int idigit = 0, count = 0;

            for (int i = 1; no > 0; i++)
            {
                idigit = no % 10;
                count++;
                no = no / 10;

            }
            Console.WriteLine(count);
        }
    }
}
