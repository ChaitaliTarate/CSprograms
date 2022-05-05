using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Array2
{
    class InsertPos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
           
            int[] arr = new int[size];

            Console.WriteLine("Enter the elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("insert the element at position");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements");
             int x = Convert.ToInt32(Console.ReadLine());

            
            int[] arrnew = new int[size + 1];

            for (int i = 0; i < size+1; i++)
            {
                if (i < pos- 1)
                {
                    arrnew[i] = arr[i];

                }
                else if (i == pos - 1)
                {
                    arrnew[i] = x;
                }
                else
                {
                    arrnew[i] = arr[i - 1];
                }
                
            }

            Console.WriteLine("After Insrtion");
                for (int i = 0; i < size+1; i++)
            {
                Console.WriteLine(arrnew[i]);
            }
        }
    }
}
