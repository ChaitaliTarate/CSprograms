using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit");
            int no = Convert.ToInt32(Console.ReadLine());
            int idigit = 0, count = 0;

           
            int sum = 0;

            if (no >99 && no <1000)

            {
                Console.WriteLine("no 3 digit");
                
                for (int i = 0; no > 0; i++)
                { 
                     idigit = no % 10;
                    count++;
                   if(count==1 || count==3)
                    {
                        sum = sum + idigit;
                    }
                    no = no / 10;

                }
                Console.WriteLine("Sum of digit" + sum);

            }
            else
            {
                Console.WriteLine("no is not 3 digit");
            }
            
          
           

        }
    }
}
