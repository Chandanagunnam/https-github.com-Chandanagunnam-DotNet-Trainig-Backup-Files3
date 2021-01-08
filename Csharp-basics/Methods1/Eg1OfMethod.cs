using System;

namespace Methods1
{
    //<Access_Specifier> <Return_Type> Method_Name(<Parameters>) { // Statements to Execute
    class Eg1OfMethod
    {
        //Method with void return type
        void Welcome()
        {
            Console.WriteLine("Good Morning !!");
        }
        //Method with return types
        //Method with string return types
        string GetName()
        {
            return "Chandana";
        }
        // Method with int return types
        int GetAge()
        {
            return 22;
        }

        //Method with character return types
        Char Surname()
        {
            return 'G';
        }
        static void Main()
        {
            //obj creation
            // classname objname = new classname
            Eg1OfMethod intro = new Eg1OfMethod();
            intro.Welcome();
            Console.WriteLine("Name is {0}", intro.GetName());
            Console.WriteLine("Age is {0}", intro.GetAge());
            Console.WriteLine("Surname is {0}", intro.Surname());

            Console.Read();
        }
    }


}
