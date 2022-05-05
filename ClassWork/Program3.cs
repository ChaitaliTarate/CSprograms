using System;
using System.Collections.Generic;
using System.Text;
using P2;
namespace ClassWork
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many do you want");
            int no = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("which term do you want");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            
            for(int i=0;i<=n-2;i++)
            {
               // Console.WriteLine(a);
                int temp = a + b;
                a = b;
                b = temp;
                
            }
            Console.WriteLine(a);
        }

    }
}
