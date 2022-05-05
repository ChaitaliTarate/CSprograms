using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
    public class Voter
    {
         long adharcard;
        string votername;
        string votecasted;

        public void setAdharCard(long card)
        {
            adharcard = card;
        }
        public long getAdharCard()
        {
            return adharcard;
        }
        public void setVotername(string name)
        {
            votername = name;
        }
        public string getVotername()
        {
            return votername;
        }

        public void setVotecasted(string vote)
        {
            votecasted = vote;
        }

        public string getVotercasted()
        {
            return votecasted;
        }
    }
        class TestVoter
        {
            static void Main(string[] args)
            {
                Voter v1 = new Voter();

                v1.setAdharCard(123456789120);
            Console.WriteLine( v1.getAdharCard());

                v1.setVotername("Chaitali");
            string n1 = v1.getVotername();
            Console.WriteLine(n1);

            v1.setVotecasted("ABC");
              string vote1=v1.getVotercasted();
            Console.WriteLine(vote1);
            }
        
    }
}
