using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Assign2pro17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no:");
            int no = Convert.ToInt32(Console.ReadLine());
            int idigit = 0;
            int temp=no;
           
            int rev = 0;
            while(no>0)
             {
                idigit = no % 10;
               rev = rev * 10 + idigit;
                no = no / 10;
            }
         //   Console.WriteLine(rev);
            if(rev==temp)
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
