using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsConcept
{
    //generic has datatype parameter is 'T'
    class Sample<T>
    {
        T oil;
        int diesel = 5;
        internal Sample(T oil)
        {
            this.oil = oil;
        }
        //Normal Method
        //both generic and non generic methods a class can have
         void Swapofnumbers(int n1,int n2)
          {
        int t;
        t = n1;
        n1= n2;
        n2 = t;
         }
        //Generic Method
        internal void Swap<T>(T n1,T n2)
        {
            Console.WriteLine("before swap: {0},{1}", n1, n2);
            T t;
            t = n1;
            n1 = n2;
            n2 = t;
            Console.WriteLine("After swap: {0},{1}", n1, n2);
        }
    }
    class GenericExample
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("10litre");
            Sample<int> s1 = new Sample<int>(10);
           // Console.WriteLine("{0);
            // swapping
            sample.Swap<int>(10, 96);
            sample.Swap<string>("tom", "jerry");
            Console.Read();
        }
    }
}
