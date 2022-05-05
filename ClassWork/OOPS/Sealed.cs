using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
    class Parent

    {
      public virtual void Study()
        {
            Console.WriteLine("HEllo");
        }

    }

    class Child:Parent
    {
        public sealed override void Study()
        {
            Console.WriteLine("Hii");
        }
    }


    class ParentTest
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Study();
            Parent p1 = new Child();
            p1.Study();
        }
    }
}
