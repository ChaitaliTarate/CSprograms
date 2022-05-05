using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class assign2pro6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the last no");
            int no = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= no; i++)
            {
                if (i % 2 == 0)
                { 
                sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
