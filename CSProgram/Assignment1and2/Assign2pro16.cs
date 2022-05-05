using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Assign2pro16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int no = Convert.ToInt32(Console.ReadLine());

            int idigit = 0;
            int fact = 1;
            int sum = 0;
            int temp = no;
            int num = 0;
            while (no>0)
            {
                idigit = no % 10;
                num = idigit;
               
               while(no>0)
                {
                    fact = fact * no;
                    no++;
                }
               // Console.WriteLine(fact);
               while(temp>0)
                {
                    sum =sum+ fact;
                    temp = temp % 10;
                    temp = temp / 10;

                }
            }
            if (sum == temp)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

    }
}
