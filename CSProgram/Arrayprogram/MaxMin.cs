using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Arrayprogram
{
    class MaxMin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements");
            for(int i=0; i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int Max = arr[0];
            for (int i=0;i<arr.Length;i++)
            {
               
                if(arr[i]>Max)
                {
                    Max = arr[i];
                }
                
            }
            Console.WriteLine("Max"+Max);

            int Min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < Min)
                {
                    Max = arr[i];
                }

            }
            Console.WriteLine("Min" + Min);

        }
    }
}
