using System;

namespace Inheritance
{
    //eg:child is inheriting from mother and father--multiple inheritance--concept of interface
    interface INormalCalculator
    {
        //int c =10;
        //error
        /* internal void RBIEmployee()
         * {
         Console.WriteLine("RBI employee details :{0}",empno);
    }*/

        int Add(int a, int b);//by default interface methods abstract,public
        string CalcName();
    }
    //eg:child is inheriting from mother and father--multiple inheritance--concept of interface
    class Computing :INormalCalculator,IScientificcalculator//implemets
    {
        internal string Getname()

        {
            return "computing";
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
        string INormalCalculator.CalcName()//no need of public
        {
            return "NormalCalculator";
        }
        string IScientificcalculator.CalcName()//no need of public
        {
            return "ScientificCalculator";
        }
    }
    class InterfaceExample
    {
        static void Main()
        {
            Computing computing = new Computing();
            Console.WriteLine("Addition {0}", computing.Add(75,45));
            Console.WriteLine("classname {0}", computing.Getname());

            /// object creation through the interfaces to acces calcname which is present in both inormal and iscientific calculator
            IScientificcalculator objs = new Computing();
            Console.WriteLine(objs.CalcName());
            INormalCalculator objn = new Computing();
            Console.WriteLine( objn.CalcName());

            Console.Read();
        }
    }
}
