using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Pattern
{
    class Class9
    {
        static void Main(string[] args)
        {
            int k = 1;
                for(int i=1;i<=6;i++)
            {
                for(int j=1;j<i+1;j++)
                {
                    Console.Write(k++ +" ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
