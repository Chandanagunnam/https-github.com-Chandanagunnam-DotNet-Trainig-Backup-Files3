using System;
namespace LoopAndConditionalStatement
{
    class ReverseOfNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number in which digits to be reveresed");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number in reveresed order is");
            //int rev = 0;
            while (num != 0)
            {
                int rem = num % 10;
                //rev = rev * 10 + rem;
                num = num / 10;
                Console.Write(rem);
            }
           // Console.Write("revere is {0}", rev);
            
           
            Console.Read();
        }

    }
}
