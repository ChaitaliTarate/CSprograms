using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Pattern
{
    class Class10
    {
        static void Main(string[] args)
        {
            char ch = '\0';
           
            for (int i = 1; i<=5;i++)
            {
                ch = 'A';
                for (int j = 1; j <= 5-i+1; j++)
                {
                    Console.Write(ch);
                    ch++;
                }

              
                Console.WriteLine();
            }
        }
    }
}
