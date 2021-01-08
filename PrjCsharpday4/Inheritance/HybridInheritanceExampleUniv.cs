using System;
using System.ComponentModel.Design;

namespace Inheritance
{
    class AICTE
    {
        protected string rule1 = "sophisticated Infracture in classroom";
        protected string rule2 = "Lab setups mandatory";
     protected void Standards()
        {
            Console.WriteLine("Rules for colleges {0} and {1}",rule1,rule2);
        }
    }
    class MumbaiUniv:AICTE
    {
        int Mtotalstudents = 600;
       internal int Muniv_no = 56789;
        internal void DisplayMum()
        {
            Console.WriteLine("total ={0}, univ no. = {3},rules :{1} and {2}", Mtotalstudents, rule1,rule2,Muniv_no);
            Standards();
        }
        

    }
    class AnnaUniv:AICTE
    {
        int Atotalstudents = 1800;
       internal int Auniv_no = 986132;
       internal void DisplayAnna()
        {
            Console.WriteLine("total ={0}, univ no. = {3},rules :{1} and {2}", Atotalstudents, rule1,rule2,Auniv_no);
            Standards();
        }


    }
    class HybridInheritanceExampleUniv
    {
        static void Main()
        {
            MumbaiUniv obmum = new MumbaiUniv();
            obmum.DisplayMum();
            Console.WriteLine(obmum.Muniv_no);

            AnnaUniv obanna = new AnnaUniv();
            obanna.DisplayAnna();
                Console.WriteLine(obanna.Auniv_no);
            Console.Read();
        }
    }
}
