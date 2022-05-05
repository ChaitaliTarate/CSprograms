using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.programstring
{
    class Sorting
    {
        static void Main(string[] args)
        {
            string[] nm = { "om", "ajay", "jiya", "tiya", "piya" };

            for (int i = 0; i < nm.Length - 1; i++)
            {
                for (int j = 0; j < nm.Length - 1 - i; j++)
                {
                    if (nm[j].CompareTo(nm[j + 1]) >= 1)
                    {
                        string t = nm[j];
                        nm[j] = nm[j + 1];
                        nm[j + 1] = t;
                    }
                    
                }
              
            }
            foreach (string a in nm)

            {
                Console.WriteLine(a);
            }
        }
    }
}
