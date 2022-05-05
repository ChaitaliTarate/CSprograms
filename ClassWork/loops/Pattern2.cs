using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.loops
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=9;i=i++)
            {
                for (int k = 1; k <= 9 - i; k++)
                {
                    Console.Write(" ");
                }

                for (int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
