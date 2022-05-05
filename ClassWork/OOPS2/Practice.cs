using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS2
{
    class Parent1
    {
        private protected int A;
        protected internal int B;

        internal void M1()
        {
            Console.WriteLine("In M1 method");
        }

        internal virtual void M2()
        {
            Console.WriteLine("In M2 method");
        }

        static internal void M3()
        {
            Console.WriteLine("M3 Parent class static method ");
        }

        /*  static virtual internal void M4()
          {
              Console.WriteLine("M4 Parent class static method ");
          }
          */
        /*sealed internal void M5()
        {
            Console.WriteLine("sealed method in M5");
        }
        */
        /*sealed static internal void M6()
        {
            Console.WriteLine("sealed method in M6 static");
        }
        */
        private protected void M7()
        {
            Console.WriteLine("private protected method");
        }

    }


    class Child1 : Parent1
    {
        void Main()
        {
            Console.WriteLine(A);
            Console.WriteLine(B);
        }

        internal new void M1()
        {
            Console.WriteLine("metod hiding.child M1 method");
        }

        internal override void M2()
        {
            // base.M2();

            Console.WriteLine("method overriding.child M2 method");
        }

        static internal new void M3()
        {
            Console.WriteLine("static metod hiding.child M3 method");
        }

        /* static  override internal void M4()
         {
             Console.WriteLine("static metod overriding.child M4 method");
         }
        */
    }


    sealed class SubChild : Child
    {

    }
}
