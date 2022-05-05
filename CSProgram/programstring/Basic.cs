using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.programstring
{
    class Basic
    {
        static void Main(string[] args)
        { 
            StringBuilder sbb = new StringBuilder("chaitali");
            sbb.Append("shweta");
            sbb.Append("pooja");
            Console.WriteLine(sbb);
          
            sbb.Insert(0, "sayali");
            Console.WriteLine(sbb);
           
            StringBuilder dd = sbb.Remove(3, 4);
            Console.WriteLine(dd);

            sbb.Replace('a', 'o');
            // string ss=sbb.ToString();

            StringBuilder ss1 = new StringBuilder("Shivsagar");
            StringBuilder ss2 = new StringBuilder("Shivsagar");
            Console.WriteLine(ss1==ss2);

            string s1 = new string("shivsagar");
            string s2 = new string("shivsagar");
            Console.WriteLine(s1==s2);
        }
    }
}
