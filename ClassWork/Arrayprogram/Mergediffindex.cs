using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Arrayprogram
{
    class Mergediffindex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of first array");
            int s1 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[s1];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("enter the size of first array");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[s2];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }


            int[] arr3 = new int[s1 + s2];

            int k = 0;
            for(int i=0;i<arr3.Length;)
            {
                if(k<arr.Length && k<arr2.Length)
                {
                    arr3[i] = arr[k];
                    i++;
                    arr3[i] = arr2[k];
                    i++;
                }
                else if(k<arr.Length)
                {
                    arr3[i] = arr[k];
                    i++;
                }
                else
                {
                    arr3[i] = arr2[k];
                    i++;
                }
            }
            foreach(int a in arr3)
            {
                Console.WriteLine(a);
            }
        }
    }
}
