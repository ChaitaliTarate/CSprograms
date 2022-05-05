using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.assignmentarray
{
    class Copy
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };


            for (int r = 0; r < arr.GetLength(0); r++)
            {
                int start = 0;
                int end = arr.GetLength(1)-1;
                while (start < end)
                {
                    int temp = arr[r,start];
                    arr[r, start] = arr[r, end];
                    arr[r, end] = temp;
                    start++;
                    end--;
                }
            }
                
            for(int r = 0; r < arr.GetLength(0); r++)
            {
                for(int c=0;c<arr.GetLength(1);c++)
                {
                    Console.WriteLine(arr[r,c]);
                    
                }
            }
        }

    }
}
