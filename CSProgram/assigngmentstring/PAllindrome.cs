using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.assigngmentstring
{
    class PAllindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s1 = Console.ReadLine();

            string rev = "";
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                rev = rev + s1[i];
            }
            /*if (s1 == rev)
            {
                Console.WriteLine("string is pallindrome");
            }
            else
            {
                Console.WriteLine("string is not pallindrome");
            }*/

            

        }
        

    }
}
