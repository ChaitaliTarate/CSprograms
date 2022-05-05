using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.program_string
{
    class Trim
    {
        static void Main(string[] args)
        {
            string str = "   chaitali   ";
            Console.WriteLine(str);

            string[] strarr = str.Split(" ");
            int j = 0;
            
            for(int i=0;i<strarr.Length;i++)
            {
                if(strarr[i].Length!=0)
                {
                    j = i;
                    break;
                }
            }
            for(int k=j;k<strarr.Length;k++)
            {
                Console.WriteLine(strarr[k]+" ");
            }
        }
        
    }
}
