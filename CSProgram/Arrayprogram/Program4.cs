using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Arrayprogram
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size 1st of array");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the size of 2nd array");
            int size1 = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            int[] arr1 = new int[size1];

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            for (int i = 0; i < arr.Length; i++)
            {
               
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr2 = new int[arr1.Length+arr.Length];

            for (int i = 0; i <arr.Length; i++)
            {
                arr2[i] = arr[i] + arr1[i];
                Console.WriteLine("array is"+arr2[i]);
            }
            
        }
    }
}
