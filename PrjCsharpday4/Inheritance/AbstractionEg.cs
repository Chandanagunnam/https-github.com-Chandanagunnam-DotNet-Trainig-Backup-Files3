using System;

namespace Inheritance
{
    abstract class RBI
    {
        public abstract int Homeloan();
        public abstract int Educationloan();
        //abstract class can have variable
        int emplono = 569;

        //non abstract method
        internal void RBIEmployee()
        {
            Console.WriteLine("RBI employee details {0}", emplono);
        }
    }

    class SBI : RBI
    {
        public override int Homeloan()
        {
            return 10;
        }
        public override int Educationloan()
        {
            return 12;
        }
    }
    class HDFC : RBI
    {
        public override int Homeloan()
        {
            return 10;
        }
        public override int Educationloan()
        {
            return 9;
        }
    }

    class AbstractionEg
    {
        static void Main()
        {
            SBI sbi = new SBI();
            HDFC hdfc = new HDFC();
            //cant create object for abstract class (rbi)
            //RBI r = new RBI
            //so,accessing rbi informt through sbi and hdfc
            sbi.RBIEmployee();
            hdfc.RBIEmployee();
            Console.WriteLine("SBI --- education loan  = {0} || Homeloan = {1}", sbi.Educationloan(), sbi.Homeloan());
            Console.WriteLine("HDFC----education loan = {0} || Homeloan = {1}", hdfc.Educationloan(), hdfc.Homeloan());

            //Run Time Polymorphism ex: over riding
            RBI r;
            //object creation for SBI,refering to RBI r
            r = new SBI();
            Console.WriteLine("run time polymorphism");
            r.RBIEmployee();
            Console.WriteLine("SBI education loan  = {0}and SBI Homeloan = {1}", r.Educationloan(), r.Homeloan());
            r = new HDFC();
            Console.WriteLine("HDFC education loan  = {0} and HDFC Homeloan = {1}", r.Educationloan(), r.Homeloan());

            Console.Read();
        }
    }
}

