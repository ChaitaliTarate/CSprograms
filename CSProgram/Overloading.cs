using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram
{
    class Overloading
    {
        public void Add(int x,int y,int z)
        {
            Console.WriteLine((x+y+z)+"In Addd");
        }

        public void Add(int b,int c)
        {
            Console.WriteLine("in sub");
        }

        static void Main(string[] args)
        {
            Overloading o1 = new Overloading();
            o1.Add(1, 2, 30);
        }
    }
}
