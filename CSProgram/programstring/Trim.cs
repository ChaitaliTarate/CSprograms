using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.programstring
{
    class Trim
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();

            string s1=s.Trim();
            Console.WriteLine(s1);
        }
    }
}
