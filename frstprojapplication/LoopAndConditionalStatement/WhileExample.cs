using System;
namespace LoopAndConditionalStatement
{
    class WhileExample
    {
        static void Main()
        {
            int EndValue, initialValue = 1;
            Console.WriteLine("Enter the end value to be printed");
            EndValue = Convert.ToInt32(Console.ReadLine());

            while (EndValue >= initialValue)
            {
               
                if (initialValue % 2 == 0)
                {
                    Console.WriteLine("{0} is even", initialValue);

                }
                initialValue++;


            }
            Console.Read();


        }
    }
}
