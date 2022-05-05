using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Mycollection
{
    class Class1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Count);
            Console.WriteLine(al.Capacity);

            al.Add("sudhir");
            al.Add(90);
            al.Add("Sudhir@gmail.com");
            al.Add(true);
            al.Add("A");
            al.Insert(1, "suraj");
            al.Remove("suraj");//al.Remove(2);
            int ii = al.IndexOf("sudhir");
            Console.WriteLine(ii);
            // al.Reverse();

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

        }
        }

        class Class2
        {
            static void Main(string[] args)
            {
                Hashtable ht = new Hashtable();

                ht.Add("pritesh", 90);
                ht.Add("omkar", 92);
                ht.Add("deepa@Gmail.com", "Trainer");
              // ht.Add("omkar", 100);


            foreach(var k in ht.Keys)
            {
                Console.WriteLine("key="+k+"  value="+ht[k]);
                Console.WriteLine(ht["omkar"]);
            }

            foreach(DictionaryEntry e in ht)
            {
                Console.WriteLine(e.Key);
            }
        }
      
    }
}
