﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Pattern
{
    class Class14
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int k=5;k>=i;k--)
                {
                    Console.Write(" ");
                }

                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            for(int i=4;i>=1;i--)
            {
                for (int k =5; k>=i; k--)
                {
                    Console.Write(" ");
                }

                for (int j=i;j>=1;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
