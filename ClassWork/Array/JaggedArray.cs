using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Array
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];

            arr[0] = new int[2];
            arr[1] = new int[3];
            arr[2] = new int[3];

            for(int r=0;r<arr.GetLength(0);r++)
            {
                Console.WriteLine($"enter {arr[r].Length} elements on row:"+r);
                for(int c=0;c<arr[r].Length;c++)
                {
                    arr[r][c] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int r = 0; r < arr.GetLength(0); r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    Console.WriteLine(arr[r][ c]);

                }
            }

        }
    }
}
