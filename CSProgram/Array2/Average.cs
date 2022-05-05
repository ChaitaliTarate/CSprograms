using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Array2
{
    class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
           
            int sum = 0;
            int avg = 0;

            Console.WriteLine("Enter the elements:");
            for(int i=0;i<arr.Length;i++)
            {
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + arr[i];
               
            }
            Console.WriteLine("sum of eleemts"+sum);
             avg = sum/size;
            Console.WriteLine("Average of elements :"+avg);
            }
        
    }
}
