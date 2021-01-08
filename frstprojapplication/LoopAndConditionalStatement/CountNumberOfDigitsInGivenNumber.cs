using System;

namespace LoopAndConditionalStatement
{
    class CountNumberOfDigitsInGivenNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number in which digits to be counted");
            int num = Convert.ToInt32(Console.ReadLine());
            int count=0;
             while(num != 0) 
            {
                num = num / 10;
                count++;
            }
            Console.Write("Number Of digits is {0}",count);
            Console.Read();
        }

    }       
}
