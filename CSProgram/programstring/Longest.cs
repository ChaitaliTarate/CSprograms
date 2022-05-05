using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.programstring
{
    class Longest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();

           string[] word = s.Split("");
            string lWord = word[0];
           
           for(int i=0;i<word.Length;i++)
            {
                if(lWord.Length<=word[i].Length)
                {
                    
                }
            }

            
        }
    }
}
