using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS2
{
    class Parent
    {
        public virtual void accept()
        {
            Console.WriteLine("HEllo everyone");
        }

        void display()
        {
            Console.WriteLine("Hiii");
        }

    }

    class Child:Parent
    {
        public override void accept()
        {
            Console.WriteLine("welcome to TQ");
        }
    }

    class OOPSTEST
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            p1.accept();
            Parent p2 = new Child();
            p2.accept();
            Child ch = new Child();
            ch.accept();
        }
    }
}
