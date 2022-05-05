using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Arrayprogram
{
    class Oddcount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                    if(arr[i]%2!=0)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
    }
}