using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Assignment
{
    public delegate void MyDelegate();
    public class User
    {

        public event MyDelegate AgeEvent;
        public void AcceptAge(int age)
        {
            if (age < 18)
                AgeEvent();
            Console.WriteLine($"Your age  {age}");
        }
    }

    class Program
    {
        static void ErrorMsg()
        {
            Console.WriteLine("your age is less than ");
 
        }
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.AgeEvent += new MyDelegate(ErrorMsg);
            u1.AcceptAge(23);
        }
    }
}
