using System;
namespace class_objects
{
    class Pen
    {
        int ISBN;
        string brand;
         string color;
        //constructor--special method --same name as class-- default private
        //constructor--initialize the value for the variables
        internal Pen(string b, string color)
        {
            brand = b;
            //this refers to current class instance(object)--->Pen
            // this.color -------> refers to string color
            //color------> internal Pen(string....color)(constriuctor method)
            this.color = color;
        }
        //constructor --- any number of contructors can be created and the name shoould be same as that of class name 
        //constructor---the constructors differs in argument list
        //constructor dont have return type--only void type
        //constructor overloading-- any no. of constructors
        //overloading - same informatn behaves differntly based on situation
        //eg of overloading --- you -- home--- work(buy vegetables)
        //                      you -- office--work(office work)
        internal Pen() //no arguments
        {
            Console.WriteLine("Default Constructor");
        }
        internal Pen(int ISBN) //1 argument
        {
            this.ISBN = ISBN;
            Console.WriteLine("ISBN");
        }
        internal void Displaypen()
        {
            Console.WriteLine("brand = {0}  || color = {1} ", brand, color);
        }
    }
    class ConstructorEg
    {
        static void Main()
        {
            //obj creation
            Pen pen = new Pen("parker", "blue");//call constructor with 2 arguments
            //pen is object;Pen is class
            //constructr 
            /* pen.brand = "parker";
             * pen.color ="blue"; */
            pen.Displaypen();
            //difft obj name for difft constructors
            Pen pen1 = new Pen(1234);//call contsructor with 1 argument
            Pen pen2 = new Pen();//call constructr with 0 arguments            
            Console.Read();
        }

    }
}