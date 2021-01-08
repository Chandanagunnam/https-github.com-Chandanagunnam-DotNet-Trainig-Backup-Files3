using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Sorted_ListEx
    {
        static void Main()
        {
            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("e", 150);
            sl.Add("a", 250);
            sl.Add("b", 160);
            sl.Add("f", 158);
            foreach(KeyValuePair<string,int> s in sl )
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();



        }
    }
    
    
}
