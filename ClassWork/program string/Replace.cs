using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.String
{
    class Replace
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter name");
            string s = Console.ReadLine();

            for(int i=0;i<s.Length;i++)
            {
                char c = s[i];
                Console.WriteLine(Convert.ToChar(c+1));
            }


            /*  Another method

            Console.WriteLine(s[0]);
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine((char)(s[i]+1));
            }

            */
            }
    }
}
