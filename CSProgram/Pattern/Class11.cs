using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Pattern
{
    class Class11
    {
        static void Main(string[] args)
        {
                for(int i=1;i<=5;i++)
            {
               for(int k=5-i;k>=1;k--)
                {
                    Console.Write(" ");
                }
               

                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
