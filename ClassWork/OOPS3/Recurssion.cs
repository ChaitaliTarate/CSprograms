using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS3
{
    class Recurssion
    {

        public static int Factorial(int n)
        {
           if(n==1)
            {
                return 1;
            }
            else
            {
                int ans = Factorial(n - 1);
                return n * ans;
            }
        }
        static void Main(string[] args)
        {
            Recurssion.Factorial(5);
        }
    }
}
