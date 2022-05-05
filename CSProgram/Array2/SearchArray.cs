using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Array2
{
    class SearchArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the element to search");
            int pos = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            bool flag = false;

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == pos)
                {
                    Console.WriteLine(i);
                    flag = true;
                }

            }
            if(flag==false)
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
