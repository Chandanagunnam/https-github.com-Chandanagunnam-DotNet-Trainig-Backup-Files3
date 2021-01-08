using System;

namespace Csharp_Basics
{
    class StringExample
    {
        static void Main()
        {
            String firstname = "Chandana Anuja";
            Console.WriteLine("Length of string:{0}",firstname.Length);
            Console.WriteLine("Convert to uppercase:{0}", firstname.ToUpper());
            Console.WriteLine("Contains:{0}", firstname.Contains("tha"));
            Console.WriteLine("Contains:{0}", firstname.Contains("dana Anu"));
            Console.WriteLine("Index of a:{0}", firstname.IndexOf("a"));
            Console.WriteLine("Checks weather" 
                + "first character starts with :{0}", firstname.StartsWith("G"));
            Console.Read();








        }
    }
}
