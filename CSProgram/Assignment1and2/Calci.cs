using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Calci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st no");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1st no");
            int no2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your choice!!! 1:Addition 2:Substraction 3:Multiplication 4:Division");
            int ch = Convert.ToInt32(Console.ReadLine());
        
        switch(ch)
            {
                case 1: Console.WriteLine("Addition is:"+(no1+no2));
                    break;

                case 2:
                    Console.WriteLine("Substraction is:" + (no1-no2));
                    break;

                case 3:
                    Console.WriteLine("Multiplication is:" + (no1 * no2));
                    break;

                case 4:
                    Console.WriteLine("Division is:" + (no1 / no2));
                    break;


                default:
                    Console.WriteLine("invalid");
                    break;
            }
        }

    }
}
