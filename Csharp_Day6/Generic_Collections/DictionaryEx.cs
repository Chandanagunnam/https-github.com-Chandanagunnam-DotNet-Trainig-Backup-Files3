using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    //use of generic collectn--making type safe---so that unneccessary unboxing and boxing not happen
    class DictionaryEx
    {
        static void Main()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(5, "a");
            dt.Add(8, "i");
            dt.Add(3, "c");
            //error --here key is int 
            // dt.Add("p", "a");
            //error --here value is string
            //dt.Add(10, 15);
            Console.WriteLine("contains {0}",dt.ContainsKey(18));
            Console.WriteLine("count {0}", dt.Count);


            foreach (KeyValuePair<int,string> k in dt)
                    {
                Console.WriteLine(k.Key + " " + k.Value);
            }
            Console.Read();
        }
    }
}
