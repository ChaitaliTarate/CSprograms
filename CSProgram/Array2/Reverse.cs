using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Array2
{
    class Reverse
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("reverse Array is");
            
            for (int i = arr.Length-1; i >=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("alternate element is=");
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
                }
        }
}
}
