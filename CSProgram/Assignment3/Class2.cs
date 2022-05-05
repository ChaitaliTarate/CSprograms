using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment3
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int no = Convert.ToInt32(Console.ReadLine());

           // int fact = 1;
            for(int i= 1;i<= no;i++)
                {
                if(no%i==0)
                {
                    Console.WriteLine(i);
                }
                   
                }
               
            
        }
    }
}
