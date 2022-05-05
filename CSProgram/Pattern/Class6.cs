using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Pattern
{
    class Class6
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5-i+1;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
