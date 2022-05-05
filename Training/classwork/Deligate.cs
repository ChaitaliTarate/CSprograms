using System;
using System.Collections.Generic;
using System.Text;

namespace Training.classwork
{
    public delegate int MyDelegate(int n1, int n2);
  public class Calculator
    {

        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mult(int a, int b)
        {
            return a*+ b;
        }
    }

    class Test2
    {
        static void Main(string[] args)
        {


            Calculator c = new Calculator();
            MyDelegate mydel = new MyDelegate(c.Add);
             mydel += new MyDelegate(c.Sub);
            mydel += new MyDelegate(c.Mult);

           // mydel -= new MyDelegate(c.Mult);   //////////remove method referance from the invocation list


            Delegate[] list = mydel.GetInvocationList();
            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(45,32));
            }

        } 
        
    }
}
