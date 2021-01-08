using System;
namespace class_objects
{
    class Mobile
    {
        internal static string companyname;//class variable (static)
        internal  string modelname;//object variable
        //non static method can access both static and non static variables
        void DisplayModel()
        {
            Console.WriteLine("companyname: {0} ,, modelname:{1}", companyname, modelname);
        }
        //static method can access only static variables ..
        //static method cant access non static variables..
        internal static void Getdata()
        {
            Console.WriteLine("companyname: {0} ,,", companyname /*, modelname*/);
        }
        //static method can access only static variables and lcal variables inside it
        internal static void Getdata2()
        {
            int isbn = 1900;
            Console.WriteLine("isbn: {0} ,,company name:{1}", isbn, companyname);

        }
    }
   
        class StaticEg2
    {
        //float f = 34090f;
        internal static void Info()
        {
            Console.WriteLine("static method");
        }
        static void Main()
        {
            //error--trying to access non static member inside static funcin
            // f = f+ f;
            Mobile objmobile = new Mobile();
            objmobile.modelname = "moto g4 plus";
            //accesing static variable through class(but not object)
            Mobile.companyname = "Motorolla";
            Mobile.Getdata();
            Mobile.Getdata2();
            //Info methos and static main method are in same class.class name not required to access static
            Info();
            Console.Read();
        }
    }
}
