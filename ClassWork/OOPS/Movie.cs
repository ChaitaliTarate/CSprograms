using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.OOPS
{
    class Movie
    {
        string moviename;
        string Direcrtor;
        string producer;
        string Actorname;
        int rating;

        public Movie()
        {
            Console.WriteLine("I movie cunstructor");
        }
        public void setMoviename(string m_name)
        {
            moviename = m_name;

        }
        public string getMoviename()
        {
            return moviename;
        }

        public void setDirectorname(string d_name)
        {
            Direcrtor = d_name;

        }
        public string getDirectorname()
        {
            return Direcrtor;
        }


        public void setProducername(string p_name)
        {
            producer = p_name;

        }
        public string getProducername()
        {
            return producer;
        }

        public void setActorname(string a_name)
        {
            Actorname = a_name;

        }
        public string getActorname()
        {
            return Actorname;
        }

        public void setRating(int r)
        {
            rating = r;
        }

        public int getRating()
        {
            return rating;
        }
    }

   class TestMovie
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
           
            Console.WriteLine("enter the movie name");
           string mname = Console.ReadLine();
          m1.setMoviename(mname);
          
            Console.WriteLine("enter the Director name");
            string dname = Console.ReadLine();
            m1.setDirectorname(dname);
           
            Console.WriteLine("enter the Producer name");
            string pname = Console.ReadLine();
            m1.setProducername(pname);
            
            Console.WriteLine("enter the actor name");
            string aname = Console.ReadLine();
            m1.setActorname(aname);
           

            Console.WriteLine("give your rating");
           int r = Convert.ToInt32(Console.ReadLine());
            m1.setRating(r);

            Console.WriteLine("Movie name is:" + m1.getMoviename());
            Console.WriteLine("Director name is:" + m1.getActorname());
            Console.WriteLine("Producer name is:" + m1.getProducername());
            Console.WriteLine("Actor name is:" + m1.getActorname());
            Console.WriteLine("rating is:"+m1.getRating());

            if(r>3)
            {
                Console.WriteLine("hit");
            }
            else
            {
                Console.WriteLine("Flop");
            }
        }
    }
}
