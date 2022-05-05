using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.programstring
{
    class Append
    {
        static void Main(string[] args)
        {
           // string s = "asf";
            StringBuilder sbb = new StringBuilder("Suraj");
            sbb.Append("Yogesh");

            Console.WriteLine(sbb);
            sbb.Insert(0, "gaurav");
            Console.WriteLine(sbb);
            StringBuilder dd = sbb.Remove(3, 4);
            Console.WriteLine(dd);

            sbb.Replace('a', 'o');
           // string ss=sbb.ToString();


        }
    }
}
