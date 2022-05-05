using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            String nm = Console.ReadLine();

            Console.WriteLine("Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter gender");
            char gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter mobile no");
            long mno = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter salary");
            int sal = Convert.ToInt32(Console.ReadLine());
        }
    }
}
