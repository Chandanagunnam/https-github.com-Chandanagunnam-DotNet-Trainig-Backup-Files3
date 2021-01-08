using System;

namespace LoopAndConditionalStatement
{
    class PrintAllTheNaturalNumbersInReverseOrder
    {
        static void Main()
        {
            Console.WriteLine("Enter the last Naturalnumber");
            uint n = Convert.ToUInt32(Console.ReadLine());
            for (uint i = n; (i <= n && i!= 0); i--) 
            {
                Console.Write(i);
                
            }
            Console.Read();
        }
    }
}
