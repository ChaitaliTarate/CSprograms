using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Assignment
{
    class Customer
    {

        public string CustName { get; set; }

        public string CustAdrress { get; set; }

        public int CustId { get; set; }
      public  List<Account> actlist = new List<Account>();
    }

    public class Account
    {
        public string Accounttype { get; set; }
        public int accountno { get; set; }

       public List<Loan> loanlist = new List<Loan>();
    }
    public class Loan
    {
        public string LoanType { get; set; }
    }
    public class Test
    {
        static void Main(string[] args)
        {
            List<Customer> cust = new List<Customer>()
            {
                new Customer{ CustId=101,CustName="manish",CustAdrress="pune",
                    actlist={ new Account{Accounttype="saving",accountno=12345,
                        loanlist={ new Loan {LoanType="Home Loan"} } } } }


            };

            foreach(Customer c in cust)
            {
                Console.WriteLine($"CustId{c.CustId}  Custname:{c.CustName} cust addres{c.CustAdrress}") ;
                foreach(Account a in c.actlist)
                {
                    Console.WriteLine($"\t account no{a.accountno} account type{a.Accounttype}");

                    foreach(Loan l in a.loanlist)
                    {
                        Console.WriteLine($"Loan{l.LoanType}");
                    }
                }
            
            }
        }
    }
}
