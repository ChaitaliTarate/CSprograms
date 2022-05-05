using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Class3
    {
        static void Main(string[] args)
        {
            int square = 1;
            for(int i=1;i<=50;i++)
            {
                if(i%2!=0)
                {
                    square = i * i;
                    Console.WriteLine(square);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
