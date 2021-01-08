using System;

namespace LoopAndConditionalStatement
{
    class SumofOddNumbersBetween1ton
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; (i <= n); i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum Of Odd Numbers from 1 to {0} is {1}", n, sum);
            Console.Read();
        }
    }
}
