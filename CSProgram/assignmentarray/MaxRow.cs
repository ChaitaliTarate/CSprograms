using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.assignmentarray
{
    class MaxRow
    {
        static void Main(string[] args)
        {


            int[,] arr = { { 22, 31, 9 }, { 12, 25, 16 } };

            int max;
            for (int r = 0; r < arr.GetLength(0); r++)
            {
                max = int.MinValue;
                for (int c = 0; c < arr.GetLength(1); c++)
                {
                    if (arr[r, c] > max)
                    {
                        max = arr[r, c];

                    }
                }
                Console.WriteLine($"max on row{r} is:{max}");
            }


            for (int c = 0; c < arr.GetLength(1); c++)
            {
                max = int.MinValue;
                for (int r = 0; r < arr.GetLength(0); r++)
                {
                    if (arr[r, c] > max)
                    {
                        max = arr[r, c];

                    }
                }
                Console.WriteLine($"max on column{c} is:{max}");
            }

        }

    }
}

