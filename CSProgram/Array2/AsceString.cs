using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Array2
{
    class AsceString
    {
        static void Main(string[] args)
        {
            string[] name = {"chaitali","sayali","pooja","shweta" };
            for(int i=0;i<name.Length;i++)
            {
                for(int j=i;j<name.Length;j++)
                {
                    if(name[i].CompareTo(name[j])>0)
                    {
                        string temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;

                    }
                }
                
            }
            Console.WriteLine();
            foreach (string n in name)
            {
                Console.WriteLine(n);
            }
        }
    }
}
