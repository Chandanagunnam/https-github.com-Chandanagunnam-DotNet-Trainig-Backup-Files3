//header file we call this as namespace
using System;

namespace basiceg
{
    class HelloWorldeg
    {
        static void Main()
        {
            //to print in consoleWindow-but we cant read--for reading console.read()
            Console.Write("Hello World");
            //to print the write in other line-writeline
            Console.WriteLine("Hello All");
            Console.WriteLine("---");
            //print name--passing values 
            //syntax for declaring variables: datatype variablename (data member)
            //syntax for declaring function: return type function() memberfn
            string myname = "Chandana", FatherName = "RamaKrishna";
            Console.WriteLine(myname);
            //concatination
            Console.Write("Concatination");
            Console.WriteLine("Example");
            Console.WriteLine("Myname:" + myname);
            //Place Holder
            Console.Write("PlaceHolder");
            Console.WriteLine("Example");
            Console.WriteLine("Myname: {0}", myname);
            Console.WriteLine("Myname: {0},{1}", myname, FatherName);
            Console.WriteLine("Myname: {1}{0}", myname, FatherName);
            Console.WriteLine("Myname: {1} {0}", myname, FatherName);
            Console.WriteLine("MyFatherName:{1} || Myname = {0}", myname, FatherName);
            Console.WriteLine("{1}", myname, FatherName);
            //to read from console window
            Console.Read();
        }
    }
}
