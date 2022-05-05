using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Myexception
{
    class InvalidMobileException : ApplicationException
    {

        public InvalidMobileException(string m) : base(m)
        {

        }
    }

    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mobile no");
            long mob = Convert.ToInt64(Console.ReadLine());
            int count = 0;
            while (mob > 0)
            {
                count++;
                mob = mob / 10;
            }
            try
            {
                if (count != 10)
                    throw new InvalidMobileException("number is less than 10 digit");
            }

            catch (InvalidMobileException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}