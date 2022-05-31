using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Assignment
{
   
    public delegate void MyDelegate1();
    class Bank
    {
     
        private double balance;
        public event MyDelegate CreditInAcc;

        public event MyDelegate Zerobalevent;

        public event MyDelegate Lessbalevent;
        public Bank()
        {
            balance = 5000;
        }
        

        public void CreditAmount(double amt)
        {
            balance = balance + amt;
            CreditInAcc();
        
        }

        public void Debit(double debit)
        {
            if(balance==0)
            {
                Zerobalevent();
            }
            else if(balance<debit)
            {
                Lessbalevent();
            }
            else
            {
                balance = balance - debit;
            }
        }
    }
    
    public class Msg
    {
        public void CreditMsg()
        {
            Console.WriteLine("your account has been credited ");

        }
        public void LowBalMsg()
        {
            Console.WriteLine("your account have no balance to debit ");

        }

        public void ZeroBalMsg()
        {
            Console.WriteLine("your account has zero balance");
        }
    }
    class Program1
    {
        
        static void Main(string[] args)
        {

            Bank b1 = new Bank();
            Msg msg = new Msg();

            b1.CreditInAcc += new MyDelegate(msg.CreditMsg);
            b1.Lessbalevent += new MyDelegate(msg.LowBalMsg);
            b1.Zerobalevent += new MyDelegate(msg.ZeroBalMsg);
            b1.CreditAmount(1000);
            b1.Debit(7000);
        }
    }
}
