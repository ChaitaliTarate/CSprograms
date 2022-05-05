using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Arrayprogram
{
    class Search
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the elements to find");
            int ele = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            bool isele = false;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if(arr[i]==ele)
                {
                    isele = true;
                }
                
            }
            if(isele==true)
            {
                Console.WriteLine("Elements is present");
            }
            else
            {
                Console.WriteLine("Element is not present");
            }
            }
    }
}
