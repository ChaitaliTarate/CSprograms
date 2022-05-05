using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Class7
    {
        static void Main(string[] args)
        {
          //  int c = 0;
            Console.WriteLine("Enter the number");
            int no = Convert.ToInt32(Console.ReadLine());
          // int sum = 0;
            int cube = no * no * no;
            bool isTriomorphic = true;

           while(no>0)
            {
                int digit1 = no % 10;
                int digit2 = cube % 10;

                if(digit1!=digit2)
                {
                    isTriomorphic = false;
                    break;
                }

                no = no /10;
                cube = cube / 10;

            }

           if(isTriomorphic)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Triomorphic");
            }

        }
    }
}
