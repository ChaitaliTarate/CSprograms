using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram._2DArray
{
    class Max
    {
        static void Main(string[] args)
        {
            int[,] arr2d = { { 11, 2, 4, 67 }, { 33, 45, 88, 5 }, { -1, -2, -3, -4 } };     //3 x 4

            int max;
            for(int r=0;r<arr2d.GetLength(0);r++)
            {
                max = int.MinValue;
                for(int c=0;c<arr2d.GetLength(1);c++)
                {
                    if(arr2d[r,c]>max)
                    {
                        max = arr2d[r, c];
                    }
                }
                Console.WriteLine($"Max on row{r} is{max}");
            }
        }
    }
}
