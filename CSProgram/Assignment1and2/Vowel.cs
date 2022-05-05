using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Vowel
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the character");
            char ch = Convert.ToChar(Console.Read());
        
        switch(ch)
            {
                case 'a':

                case 'e':

                case 'i':

                case 'o':

                case 'u': Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Consonent");
           break;
            }
        }
    }
}
