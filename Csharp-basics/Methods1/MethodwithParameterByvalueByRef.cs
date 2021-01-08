using System;

namespace Methods1
{
    class MethodwithParameterByvalueByRef
    {
        void ByValue(string p)
        {
            p = "000000000";
            Console.WriteLine("VAlue Changed inside method:p:{0}", p);

        }
        void ByReference(ref string ph)
        {
            ph = "111111111";
            Console.WriteLine("VAlue Changed inside method:ph:{0}", ph);
        }
        static void Main()
        {
            string phno = "995784612";
            MethodwithParameterByvalueByRef mobj = new MethodwithParameterByvalueByRef();
            Console.WriteLine("Before calling byvalue method:phn:{0}", phno);
            mobj.ByValue(phno);
            Console.WriteLine("after calling byvalue method:phn:{0}", phno);
            Console.WriteLine("---------");
            Console.WriteLine("Before calling byreference method:phn:{0}", phno);
            mobj.ByReference(ref phno);
            Console.WriteLine("after calling byreference method:phn:{0}", phno);
            Console.Read();
        }
    }
}
