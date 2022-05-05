using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Array2
{
    class CopyA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr=new int[size];

            Console.WriteLine("Enter the elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

             int[] brr = arr;
            Console.WriteLine("After Copy");
            for (int i = 0; i < brr.Length; i++)
            {
                Console.WriteLine(brr[i]);
            }
        }
    }
}
