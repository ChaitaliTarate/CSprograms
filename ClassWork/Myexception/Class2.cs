using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Myexception
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user name and password");
            string u = Console.ReadLine();
            string p = Console.ReadLine();
            if (u == "admin" && p == "root")
                Console.WriteLine("Log in successfull");
            else
                throw new InvalidLogInException("Please enter correct username and password");
        }
    }

    class InvalidLogInException:ApplicationException
    {
    public InvalidLogInException(string m):base(m)
        {

        }
    }
}
