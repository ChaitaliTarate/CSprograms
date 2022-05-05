using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.programstring
{
    class CountWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            int count = 1;
            
            for(int i=0;i<s.Length-1;i++)
            {
                if(s[i]==' ')
                {
                    count++;
                }
            }
            Console.WriteLine("total no o word is:"+count);
        }
    }
}
