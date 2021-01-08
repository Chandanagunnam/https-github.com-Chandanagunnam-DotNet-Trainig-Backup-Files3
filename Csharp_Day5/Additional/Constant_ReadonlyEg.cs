using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class ConstantEg
    {
        //compile time constant
        public const float pi = 3.14f;
        const int value = 10 + 20;
        //non constant variable
        int data = 80;
        /*
         //error
        //cant change value of const
        pi = 81.0;
        //cant add non const to const
        const int add = 10+data;
        //cant use static keyword for constant
        static const int val1 = 10+20; */
        internal void Perimeterofcircle(int radius)
        {
            const string name = "RAm";
            //pi = 15.0 //error
            Console.WriteLine("perimetr of circle {0}", (2 * pi * radius));
        }
    }
    class ReadonlyEg
    {
        //Run time constant
        internal readonly string SchoolName;
        internal static readonly string OrgName = "LTI";
        internal ReadonlyEg(string SchoolName)
        {
            this.SchoolName = SchoolName;
        }
        void DisplayStudent()
        {
            //error
            //cant change schoolname(readonly) in a method
            //SchoolName = "Chaitanya school";
        }

    }
    class Constant_ReadonlyEg
    {
        static void Main()
        {
            //can change readonly schoolname here
            ReadonlyEg readonlyEg = new ReadonlyEg("Varun school");
            ReadonlyEg r2 = new ReadonlyEg("KV");
            ConstantEg c = new ConstantEg();
            c.Perimeterofcircle(4);
            Console.Read();
        }
    }
}
