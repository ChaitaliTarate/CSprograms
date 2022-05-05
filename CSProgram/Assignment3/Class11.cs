using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int no2 = Convert.ToInt32(Console.ReadLine());
            bool isprime = false;

            for (int i= 2; i <=no1/ 2;i++)
                {
                while(no1%i==0)
                {
                  
                    isprime = true;
                    break;
                }
              }
            

            for (int i = 2; i <= no2 / 2; i++)
            {
                while (no2 % i == 0)
                {
                   
                    isprime = true;
                    break;
                }
            }

            if (no2 - no1 == 2)
            {
                if(no1-no2==2 || no2-no1==2)
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
