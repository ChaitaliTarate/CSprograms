using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.assignmentarray
{
    class Alternatemerge
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

            Console.WriteLine("Enter the size of 2nd array");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[size2];

            Console.WriteLine("Enter elemnts");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }



            int[] arr3 = new int[arr.Length + arr2.Length];

            
        }
    }
}
