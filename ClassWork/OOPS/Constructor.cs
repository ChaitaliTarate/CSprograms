using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
    class Constructor
    {
        int id;
        string name;
        public Constructor()
        {
            Console.WriteLine("in default constructor");
        }

        public Constructor(int id ,string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("in parameterised constroctor");
        }
        static Constructor()
        {
            int x = 100;
            Console.WriteLine("in static constructor");
            Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
            Constructor cs = new Constructor(1,"shweta");
             
        }
    }
}
