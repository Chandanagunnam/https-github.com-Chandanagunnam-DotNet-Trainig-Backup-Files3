using System;

namespace LoopAndConditionalStatement
{
    class DoWhileEx
    {
        static void Main()
        {
            int EndValue, initialValue = 1;
            Console.WriteLine("Enter the end value to be printed");

            EndValue = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("inside do while");
                Console.WriteLine("initialvalue:{0}", initialValue);
                initialValue++;
            } while (initialValue < EndValue);
            Console.Read();

        }
    }
}
