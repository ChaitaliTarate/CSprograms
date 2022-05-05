using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Class12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            long no = Convert.ToInt64(Console.ReadLine());
            

            for (int i = 15; i>=1; i--)
            {
                int digit = 0;
               
                while (no > 0)
                {
                    digit = (int)no % 10;
                    if (i%2==0)
                    {
                        Console.WriteLine(digit*2);
                    }
                    else
                    {
                        Console.WriteLine(digit);
                    }
                    no = no / 10;
                }
            }
                    
         }
    }
}
