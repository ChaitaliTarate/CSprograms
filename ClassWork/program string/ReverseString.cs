using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.String
{
    class ReverseString
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string s = Console.ReadLine();
            for(int i=s.Length-1;i>=0;i--)
            {
                Console.WriteLine(args[i]);
            }
            
        }
    }
}
