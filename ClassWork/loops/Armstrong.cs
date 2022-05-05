using System;

namespace ClassWork
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter the no:");
                int no = Convert.ToInt32(Console.ReadLine());
                int idigit = 0;
                int temp = no;
              
                int c = 0;
                while (no > 0)
                {
                    c++;
                    no = no / 10;

                }

                no = temp;

                int sum = 0;
                while (no > 0)
                {
                    idigit = no % 10;
                    sum = sum + (int)Math.Pow(idigit, c);
                    no = no / 10;
                }

                if (sum == temp)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }

}