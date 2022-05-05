using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Arrayprogram
{
    class Reverse
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sizee of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr =new int[size];

            Console.WriteLine("Enter the elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

             }
            Console.WriteLine("Reverse element are");
            for (int i = arr.Length-1; i >= 0; i--)
            {
                 Console.WriteLine(arr[i]);

            }
        }

    }
}
