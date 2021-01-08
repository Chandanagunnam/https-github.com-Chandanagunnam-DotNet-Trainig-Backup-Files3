using System;

using NormalCalculator;

namespace CallDLLExample
{
    class Employee
    {
        static void Main()
        {
            
            Calculator calculator = new Calculator();
            Console.WriteLine("addition of numbers :{0}",calculator.Addition(5, 6));
            Console.Read();
        }
    }
}
