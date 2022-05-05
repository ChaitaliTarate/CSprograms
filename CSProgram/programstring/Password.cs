using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.programstring
{
    class Password
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ente your password");
            string pass = Console.ReadLine();

            int CountUpper = 0;
            int CountLower = 0;
            int Countdigit = 0;
            int countsymbol = 0;
            if(pass.Length<5)
                Console.WriteLine("password sould contain 5 character");

            char[] ch = pass.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'A' && ch[i] <= 'Z')
                {
                    CountUpper++;
                }
                else if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    CountLower++;
                }
                else if (ch[i] >= '0' && ch[i] <= '9')
                {
                    Countdigit++;
                }
                else
                {
                    countsymbol++;

                }
            }
                if(CountUpper==0)
                {
                    Console.WriteLine("Enter at least one uppercase character");
                }

                else if(CountLower==0)
                {
                    Console.WriteLine("Enter at least one lowercase character");
                }
            else if (countsymbol == 0)
            {
                Console.WriteLine("Enter at least one special character");
            }


            else if (Countdigit == 0)
                {
                    Console.WriteLine("Enter at least one digit");
                }
                else { Console.WriteLine("Valid pass"); }
               
            
        }

    }
}
