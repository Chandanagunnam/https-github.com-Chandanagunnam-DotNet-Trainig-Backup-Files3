using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class ListEG
    {
        static void Main()
        {
            List<int> lt = new List<int>();
            lt.Add(10);
            lt.Add(89);
            lt.Add(45);
            //error--only int 
            //lt.Add("gun");
        lt.Sort();
        lt.Reverse();

            Console.WriteLine("max {0}",lt.Max());
            foreach (int item in lt)
            {
                Console.WriteLine(item);
            }
            //at index 1 removing item
            Console.WriteLine("after remove");
            lt.RemoveAt(1);
            foreach (int item in lt)
            {
                Console.WriteLine(" {0}" ,item);
            }
            Console.Read();
        }
    }
}
