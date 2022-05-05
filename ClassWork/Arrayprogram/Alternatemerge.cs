using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Arrayprogram
{
    class Alternatemerge
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4};
            int[] b = {11,22,33,44,55};

            int[] c = new int[a.Length + b.Length];
            int j = 0;

            for(int i=0;i<a.Length;i++)
            {
                c[j] = a[i];
                j = j + 2;
            }
            /*foreach(int x in c)
            {
                Console.Write(x+" ");
            }*/
            j = 1;
            for(int i=0;i<b.Length;i++)
            {
                if(j!=b.Length)
                {
                    c[j] = b[i];
                    j = j + 2;
                }
            }
            Console.WriteLine();
            foreach(int x in c)
            {
                Console.Write(x+" ");
            }
        }
    }
}
