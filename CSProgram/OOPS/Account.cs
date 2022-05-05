using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.OOPS
{
    class Account
    {
        public long Accountno;
       public String customername;
        float depositamt;
        void insert()
        {
            Console.WriteLine("Insert Account no and customer name");
            Accountno = Convert.ToInt64(Console.ReadLine());
            customername = Console.ReadLine();
        }

        void display()
        {
            Console.WriteLine($"Account no is{Accountno}");
            Console.WriteLine($"customer name is{customername}");
        }

        void deposit()
        {

        }
    }
}
