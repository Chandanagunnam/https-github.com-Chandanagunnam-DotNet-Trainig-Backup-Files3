using System;
using System.Collections;


namespace Non_GenericCollectionEg
{
    class HashTableEg
    {
        static void Main()
        {
            //hashtable accepts the informatn as key value pair
            //not sorted
            Hashtable ht = new Hashtable();
            ht.Add(1, "Monday");
            ht.Add(4, "Thursday");
            ht.Add(2, "Tuesday");
            ht.Add("sat","Saturday");
            ht.Add("s", "Saturday");
            ht.Add(5, "Saturday");
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

            Console.WriteLine("----Sorted List-----");
            //display th information in sorted order
            SortedList st = new SortedList();
            st.Add(1, "Monday");
            st.Add(4, "Thursday");
            st.Add(2, 5);
            st.Add(5, "Saturday");
            //st.Add("s", "Saturday"); (error bcz sorted takes place w.r.t keys and cannt accept difft datatype in keys)
            SortedList st1 = new SortedList();
            st1.Add("s", "Saturday");
            st1.Add("sun", "Sunday");
            st1.Add("fri", "friday");
            st1.Add("mon", "monday");
            foreach (DictionaryEntry s in st)
            {
                Console.WriteLine(s.Key + " " + s.Value);
            }
            foreach (DictionaryEntry s1 in st1)
            {
                Console.WriteLine(s1.Key + " " + s1.Value);
            }
            Console.Read();







        }
    }
}
