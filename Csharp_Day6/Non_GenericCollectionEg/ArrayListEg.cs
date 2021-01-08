using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollectionEg
{
    //collection of objects:heterogenous 
    //allows dynamic memory,duplicate values
    //index is zero based
    class ArrayListEg
    {
        static void Main()
        {
            int[] arr = { 90, 60, 89, 10, 34 };
            for (int i =0;i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("after soring");
            Array.Sort(arr);
            //for (int i =0;i < arr.Length;i++)
            //foreach(ElementI in iterable-item)
            //var:implicit  typed variable
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------ArrayListEg------");
            //ArrayList is a non generic collection.
            //present in System.Collection (namespace)
            //its a class in System.Collection (namespace)
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(82.30);
            al.Add("SIRI");
            al.Add(14);
            al.Add("James");
            al.Add("SIRI");
            foreach(var item in al)
            {
                Console.WriteLine("ArrayList:{0}",item);

            }
            Console.WriteLine("Count:{0}", al.Count);
            Console.WriteLine("Capacity:{0}", al.Capacity);
            Console.WriteLine("Contains:{0}", al.Contains("James"));
            //Console.WriteLine("revere of array:{0}", al.Reverse); (works on homogenous objects)
            al.Remove(14);
            
            Console.WriteLine("after removing one elemet");
            foreach (var item in al)
            {
                Console.WriteLine("ArrayList:{0}", item);

            }
            Console.Read();


        }
    }
}
