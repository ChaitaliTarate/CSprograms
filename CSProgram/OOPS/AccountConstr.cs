using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.OOPS
{
    class AccountConstr
    {
        public long Accountno;
        public String customername;

        public AccountConstr()
        {
            Console.WriteLine("i am in default constructor");
        }

        public AccountConstr(long Ano,String cname)
        { 
            Console.WriteLine("i am in prameterised constructor");
            Accountno = Ano;
            customername = cname;
        }

        static void Main(string[] args)
        {
            long no;
            AccountConstr a1 = new AccountConstr();
            AccountConstr a2 = new AccountConstr(1012365787,"chaitali");
        }
    }
}
