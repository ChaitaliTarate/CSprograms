using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
    class Inheritance
    {
        public void Deposit()
        {
            Console.WriteLine("Deposit ammount");
        }
    }

    class BB:Inheritance
    {
        static void Main(string[] args)
        {
            BB b = new BB();
            b.Deposit();
        }
    }
}
