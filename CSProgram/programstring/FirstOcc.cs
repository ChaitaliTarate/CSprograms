using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.programstring
{
    class FirstOcc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string s = Console.ReadLine();


            Console.WriteLine(s.IndexOf('c'));
            
        }
    }
}
