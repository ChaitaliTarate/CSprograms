using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Assign2pro11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int no = Convert.ToInt32(Console.ReadLine());
            Boolean flag = true;
            for (int i=2;i<=no/2;i++)

            {
                if(no%i==0)
                {
                    flag = false;
                }
            }

            if(flag==true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
