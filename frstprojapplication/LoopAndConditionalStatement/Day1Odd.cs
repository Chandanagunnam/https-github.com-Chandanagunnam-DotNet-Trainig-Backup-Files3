using System;
    
namespace LoopAndConditionalStatement
{
    class Day1Odd
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if((num%2) != 0)
            {
                Console.WriteLine("{0} is odd number", num);
            }
            else
            {
                Console.WriteLine("{0} is Even Number", num);
            }
            Console.Read();
        }
    }
}

