using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class WordNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch(ch)
            {
                case 1: Console.WriteLine("One");
                    break;

                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
            }
        }
    }
}
