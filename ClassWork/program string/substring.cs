using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.program_string
{
    class substring
    {
        static void Main(string[] args)
        {
            string s1 = "chaitali";
            Console.WriteLine(s1);
            string s2 = "lit";
            bool ispresent;
            int c = 0;
            
            for (int i = 0; i < s1.Length;i++)
            {
                ispresent = false;
              for(int j=0;j<s2.Length;j++)
                {
                   if(s1[i]==s2[j])
                    {
                        ispresent = true;
                    }
                }
              if(ispresent)
                {
                    Console.WriteLine("string cant be found");
                    c++;
                }
            }
           if(c!=0)
            {
                Console.WriteLine("found");
            }
        }

    }
}
