using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.assigngmentstring
{
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the seconfd string");
            string s2 = Console.ReadLine();

            string str = s1.ToLower();
            string str2 = s2.ToLower();


           char[] ch1= str.ToCharArray();
            char[] ch2 =str2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string ss1 = string.Join("", ch1);
            string ss2 = String.Join("", ch2);

            /*string news1 = new string(ch1);
            string news2 = new string(ch2);*/
            if (ss1==ss2)
            {
                Console.WriteLine("String is anagram");
            }
            else
            {
                Console.WriteLine("String is not anagram");
            }

        }
    }
}
