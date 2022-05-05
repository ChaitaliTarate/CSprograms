using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Arrayprogram
{
    class Even
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 34, 5, 6, 7, };
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.Write(a[i]+" ");
                }
            }
        }
    }
}
