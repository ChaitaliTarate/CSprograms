using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range");
            int no = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 1; i <= no; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    j = j + j - 1;
                    Console.WriteLine(j);

                }
                Console.WriteLine();
            }

        }
    }
}
