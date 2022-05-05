using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Arrayprogram
{
    class Min
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements");
           for(int i=0;i<=arr.Length-1;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }


            int min=int.MaxValue;
           for(int i=0;i<=arr.Length-1;i++)
            {
                if(min>arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("minimum in array is:"+min);
         
        }
    }
}
