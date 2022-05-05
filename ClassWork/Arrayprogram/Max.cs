using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Arrayprogram
{
    class Max
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 3, 8, 9, 2};
            int max = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(max<a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
