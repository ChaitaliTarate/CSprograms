using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Myexception
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divivsion is"+a/b);
                Console.WriteLine("try end");
            }
            catch(FormatException obj)
            {
                Console.WriteLine("please enter the no"+obj.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("divisior can be zero"+ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error"+e.Message);
            }


            for (int i = 0; i < 10; i++)
                Console.WriteLine("Welcome");


            try
            {
                Console.WriteLine("Enter age");
                int age= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("age="+age);
            }
            finally
            {
                Console.WriteLine("in finally");
            }

           
        }
    }
}
