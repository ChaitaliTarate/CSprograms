using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number");
            int no = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the 2nd number");
            int no2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0,sum1=0;

            for(int i=1;i<=no/2;i++)
            {
                if(no%i==0)
                {
                    sum = sum + i;
                   // Console.WriteLine(sum);
                }
            }
            for (int i = 1; i <= no2 / 2; i++)
            {
                if (no2 % i == 0)
                {
                    sum1 = sum1 + i;
                   // Console.WriteLine(sum1);
                }
            }

            if(sum==no2 && sum1==no)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
