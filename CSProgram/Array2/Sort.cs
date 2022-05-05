using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Array2
{
    class Sort
    {
        static void Main(string[] args)
        {
            char[] arr = {'p','o','o','j','a' };

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i;j<arr.Length;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        char temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine( );
            foreach(char a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
