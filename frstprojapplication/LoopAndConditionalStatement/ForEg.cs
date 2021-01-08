using System;

namespace LoopAndConditionalStatement
{
    class ForEg
    {
        static void Main()
        {
            int table, n;
            Console.WriteLine("Enter the table to be printed");
            table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number upto which table  to be printed");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i =1;i <= n; i = i+1)
                //syntax for(initialization;condition;increment/decrement)
            {
             Console.WriteLine("{0} * {1} = {2}", i, table, i * table);
            }
            Console.Read();
        }
    }
}
