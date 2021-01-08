using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{

    public struct Pen
    {
        internal int penid;
        public string color;
        //error
        //string type = "fountain";
    }
    class StructEg
    {
        static void Main()
        {
            Pen p = new Pen();
            p.color = "red";
            p.penid = 56123;
        }
    }
}
