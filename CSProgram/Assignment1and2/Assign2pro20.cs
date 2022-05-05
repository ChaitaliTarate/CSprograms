using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Assign2pro20
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter the no:");
           // int no = Convert.ToInt32(Console.ReadLine());
            int idigit = 0;
           
            int rev = 0,n;
            for (int no = 100; no<= 500; no++)
            {
                 n = no;
                while (n > 0)
                {
                    idigit = n % 10;
                    rev = (rev * 10 )+ idigit;
                    n = n / 10;
                   
                }
              
                if (no==rev)
                {
                    Console.WriteLine("no"+no);
                }
                
            }
            
        }
    }
}
