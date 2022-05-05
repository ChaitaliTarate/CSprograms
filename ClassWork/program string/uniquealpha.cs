using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.program_string
{
    class uniquealpha
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s1 = Console.ReadLine();

            string s2 = "";
           for(int i=0;i<s1.Length;i++)
            {
                if(s2.IndexOf(s1[i])== -1)
                {
                    s2 = s2 + s2[i];
                }
            }

        }
    }
}
