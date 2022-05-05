using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Week
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Choice");
            int no = Convert.ToInt32(Console.ReadLine());

            switch(no)
            {
                case 1: Console.WriteLine("Monday");
                    break;

                case 2 :
                    Console.WriteLine("Mon");
                    break;

                case 3:
                    Console.WriteLine("Tues");
                    break;

                case 4:
                    Console.WriteLine("Wen");
                    break;

                case 5:
                    Console.WriteLine("Thur");
                    break;

                case 6:
                    Console.WriteLine("Fri");
                    break;

                case 7:
                    Console.WriteLine("Sat");
                    break;

                default: Console.WriteLine("Day Does Not Exist");
                    break;
            }

        }
    }
}
