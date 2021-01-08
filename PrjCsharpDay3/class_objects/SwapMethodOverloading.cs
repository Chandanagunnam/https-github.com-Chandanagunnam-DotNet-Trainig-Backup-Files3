using System;

namespace class_objects
{
    //Create a class that has method to swap() 2 numbers and 2 strings (Method overloading)
    class Swapping
    {
        
       internal void Swap(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("swapped numbers: a = {0}, b= {1}", a, b);
        }
        internal void Swap(string X,string Y)
        {
           string Temp = X;
            X = Y;
            Y = Temp;
            Console.WriteLine("swapped strings are: X= {0}, Y={1}", X, Y);
        }
    }
    class SwapMethodOverloading
    {
        static void Main()
        {
            Swapping objswap = new Swapping();
           
            Console.WriteLine("enter value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter string X");
            string X = Console.ReadLine();
            Console.WriteLine("enter string y");
            string Y = Console.ReadLine();
            objswap.Swap(a, b);
            objswap.Swap(X, Y);
            Console.Read();




        }

    }
}
