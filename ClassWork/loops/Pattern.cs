using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.loops
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for (int k = 1; k <=5- i; k++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }
    }
}
