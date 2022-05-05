using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.String
{
    class Alternate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string s = Console.ReadLine();

            string rev = "";
            for (int i = s.Length - 1; i >= 0; i=i-2)
            {
                Console.WriteLine(s[i]);

            }
            Console.WriteLine(rev);
        }

    }
}
