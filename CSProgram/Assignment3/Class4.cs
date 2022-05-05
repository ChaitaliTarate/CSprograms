using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Class4
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int no = Convert.ToInt32(Console.ReadLine());
            int digit = 0;
            int sum=0;
            int temp = no;
            while(no>0)
            {
                digit = no % 10;
                sum = sum + digit;
                no=no / 10;
            }

            if(temp%sum==0)
            {
                Console.WriteLine("Harshad no");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
