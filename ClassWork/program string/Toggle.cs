using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.String
{
    class Toggle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string s = Console.ReadLine();

            int ind = s.IndexOf('a');
            Console.WriteLine("Index is:"+ind);

            int lastind = s.LastIndexOf('a');
            Console.WriteLine( "Last Index is:"+lastind);

           Console.WriteLine(s.Substring(7));
           

            Console.WriteLine("Length is"+s.Length); //Returns no of character in string including spaces

            string s2 = s.Trim();
            Console.WriteLine("After removing first snd last spacess:"+s2);

            char[] ch = s.ToCharArray();
           for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(ch[i]);
            }

            string s4 = s.Replace('c','a');
            string s3 = s.Replace("ch","aa");
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            string s5 = s.Remove(9);
            Console.WriteLine(s5);

            string dd = "";
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]!='a')
                {
                    dd = dd + s[i];
                }
            }
            Console.WriteLine(dd);
            Console.WriteLine(s.Replace("a",""));


        }
    }
}
