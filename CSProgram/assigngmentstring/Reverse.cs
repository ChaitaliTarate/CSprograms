using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.assigngmentstring
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s1 = Console.ReadLine();
            int ss1=s1.LastIndexOf(" ");
            int ss2 = s1.IndexOf(" ");
            //  Console.WriteLine(ss1);


            if (ss1 < s1.Length && ss2 < s1.Length)
            {
                for (int j = ss2; j >= 0; j--)
                {
                    Console.WriteLine(s1[j]);
                }
            }

            /* if (ss1 < s1.Length && ss2 < s1.Length)
             {
                 for (int j = s1.Length; j >= 0; j--)
                 {
                     Console.WriteLine(s1[j]);
                 }
             }*/
            /*else
            {
                for (int i = 0; i <=s1.Length-1; i++)
                {
                    Console.WriteLine(s1[i]);

                }
            }*/
        }
    

    }
}
