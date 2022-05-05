using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Assign2pro12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int no = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                int table = no * i;
                Console.WriteLine(table);
            }
        }
    }
}
