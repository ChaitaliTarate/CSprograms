using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Alphabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice");
            char ch = Convert.ToChar(Console.Read());

            if(ch>='a' && ch <='z')
            {
                Console.WriteLine("Alphabet");
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Special Character");
            }
        }
    }
}
