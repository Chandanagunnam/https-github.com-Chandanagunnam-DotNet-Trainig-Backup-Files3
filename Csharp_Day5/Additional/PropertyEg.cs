using System;

namespace Additional
{
    
    class DellLappy
    {
        //properties -to access the private variables of the class
        
        public string Laptopname { get; private set; }//get-fetch //set -setting data
        public string Ram { get; set; }
        internal DellLappy(string Laptopname, string Ram)
        {
            this.Ram = Ram;
            this.Laptopname = Laptopname;
        }
    }
    class Student
    {
        static void Main()
        {
            DellLappy d = new DellLappy("Inspiron13", "8gb");
            // d.Laptopname = "acer";//error read only informatn//set is private for laptop
            d.Ram = "16GB";
            Console.WriteLine("RAm ={0}", d.Ram);// no error --set and get are not private for Ram
            Console.Read();
        }


    }

    class PropertyEg
    {

    }
}
