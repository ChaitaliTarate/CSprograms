using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.programstring
{
    class PAllindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s1 = Console.ReadLine();
            string rev = "";
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                rev = rev + s1[i];
            }
            if(rev==s1)
            {
                Console.WriteLine("pallindrom");
            }
            else
            {
                Console.WriteLine("not pallindrome");
            }
        }
    }
}
