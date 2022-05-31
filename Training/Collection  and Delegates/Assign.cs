using System;
using System.Collections.Generic;
using System.Text;

namespace Training.classwork
{
    public delegate void MyDelegate1(string s1);
    public class Assign
    {
      // public string s1;
        public void Uppercase(string s1)
        {
           s1= s1.ToUpper();
            Console.WriteLine(s1);
        }
        public void Lowercases(string s1)
        {
            Console.WriteLine(s1.ToLower());
        }



    }

    class Test3
    {
        static void Main(string[] args)
        {

           
            Assign a = new Assign();
            MyDelegate1 mydel = new MyDelegate1(a.Uppercase);
            mydel += new MyDelegate1(a.Lowercases);

            Delegate[] list = mydel.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke("Chaitali"));
            }
        }
    }
}
