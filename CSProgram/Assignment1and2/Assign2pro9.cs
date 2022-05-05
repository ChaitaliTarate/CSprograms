using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Assign2pro9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int no = Convert.ToInt32(Console.ReadLine());
            int idigit = 0, product= 1;

            for (int i = 1; no > 0; i++)
            {
                idigit = no % 10;
                product = product * idigit;
                no = no / 10;

            }
            Console.WriteLine(product);
        }
    }
}
