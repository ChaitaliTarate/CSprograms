using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.assignmentarray
{
    class Swap
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the size of first array");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size1];

            Console.WriteLine("Enter elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("After swapping first 2 with last 2::");
            for (int i=0;i<arr.Length;i++)
            {
                int temp = arr[0];
                arr[0] = arr[arr.Length-2];
                arr[arr.Length-2] = temp;

                int temp1 = arr[1];
               arr[1] = arr[arr.Length-1];
                arr[arr.Length-1] = temp1;

                Console.WriteLine(arr[i]);
            }
        }
    }
}
