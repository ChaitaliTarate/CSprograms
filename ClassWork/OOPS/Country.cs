using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
    class Country
    {
        string countryname;
        int states;
        int languages;
        string capital;

        public string Countryname
        {
            set
            { countryname = value; }
            get
            { 
                return countryname;
            }
        }

        public int States
        {
            set
            {
                states = value;
            }
            get
            {
                return states;
            }
        }

        public int Language
        {
            set { languages = value; }
            get { return languages; }
        }

        public string Capital
        {
            set { capital = value; }
            get { return capital; }
        }

        static void Main(string[] args)
        {
            Country c1 = new Country();
            c1.Countryname="india";
            
            c1.States = 46;
           
            c1.Language = 12;

            c1.Capital = "mumbai";

            Console.WriteLine(c1.Countryname);
            Console.WriteLine(c1.States);
            Console.WriteLine(c1.Language);
            Console.WriteLine(c1.Capital);
        }
    }
}
