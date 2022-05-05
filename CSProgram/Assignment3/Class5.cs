using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Class5
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Red");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("blue");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
