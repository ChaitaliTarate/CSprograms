using System;
using System.Collections.Generic;
using System.Text;

namespace CSProgram.Assignment1and2
{
    class Currancy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount");
            int amt = Convert.ToInt32(Console.ReadLine());

            while (amt >= 2000)
            {
                int Note2000 = amt / 2000;
                amt = amt % 2000;
                Console.WriteLine("Total Number of 2000 rs notes are:" + Note2000);
            }

            while (amt >= 500)
            {
                int Note500 = amt / 500;
                amt = amt % 500;
                Console.WriteLine("Total Number of 500 rs notes are:" + Note500);
            }

            while (amt >= 200)
            {
                int Note200 = amt / 200;
                amt = amt % 200;
                Console.WriteLine("Total Number of 200 rs notes are:" + Note200);
            }

            while (amt >= 100)
            {
                int Note100 = amt / 100;
                amt = amt % 100;
                Console.WriteLine("Total Number of 100 rs notes are:" + Note100);
            }

            while (amt >= 50)
            {
                int Note50 = amt / 50;
                amt = amt % 50;
                Console.WriteLine("Total Number of 50 rs notes are:" + Note50);
            }

            while (amt >= 20)
            {
                int Note20 = amt / 20;
                amt = amt % 20;
                Console.WriteLine("Total Number of 20 rs notes are:" + Note20);
            }

            while (amt >= 10)
            {
                int Note10 = amt / 10;
                amt = amt % 10;
                Console.WriteLine("Total Number of 10 rs notes are:" + Note10);
            }

            while (amt >= 1)
            {
                int Note1 = amt / 1;
                amt = amt % 1;
                Console.WriteLine("Total Number of 1 rs notes are:" + Note1);
            }


        }
    }
}
