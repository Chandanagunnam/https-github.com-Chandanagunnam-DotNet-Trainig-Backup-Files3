using System;
namespace Csharp_Basics
{
    class TypeConversions
{
    static void Main()
    {
        //implicit conversion lower to higher
        //value type
        int salary = 20000;
        float f = salary;
        double d = f;
        Console.WriteLine("Implicit Conversion");
        Console.WriteLine("Int:{0}|| Float:{1}|| Double:{2}", salary, f, d);
        //Explicit Conversion
        float amount = 100.258f;
        int money = Convert.ToInt32(amount);
        Console.WriteLine("Implicit Conversion");
        Console.WriteLine("Float to int: {0} to {1}", amount, money);
        Console.Read();


    }
}
}

