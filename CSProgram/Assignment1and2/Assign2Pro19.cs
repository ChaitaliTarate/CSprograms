using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Assign2Pro19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int no = Convert.ToInt32(Console.ReadLine());

            int idigit = 0;
            int sum = 0;
            int temp = no;
            while(no>0)
            {
                idigit = no % 10;
                sum = sum + idigit;
                no = no / 10;
            }

            if(temp%sum==0)
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
