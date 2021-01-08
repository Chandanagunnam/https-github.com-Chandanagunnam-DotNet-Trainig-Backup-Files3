using System;
namespace LoopAndConditionalStatement
{
    /*switch(case)
     * {
     * case 1: statements break;
     * case2 :set of statements;break;;
     * 
     * case n : set of statements;break;
     * default: set of statements;break;
     * }
     */
    /* Switch case: two exampeles*/
    class SwitchCaseEx
    {
        /*
        static void Main()
        {
            int i;
            Console.WriteLine("Enter Number");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday Funday");
                    break;
                default:
                    Console.WriteLine("No day invalid day");
                    break;
            }
            Console.ReadLine();

        }
        */
        static void Main()
        {
            float num1;
            Console.WriteLine("Enter the numbers");
            float.TryParse(Console.ReadLine(), out num1);
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation to be performed");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Addition:{0}", num1 + num2);
                    break;
                case "-":
                    Console.WriteLine("Subtraction:{0}", num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("Multiplication:{0}", num1 * num2);
                    break;
                case "/":
                    Console.WriteLine("Division:{0}", num1 / num2);
                    break;
                default:
                    Console.WriteLine("Entered wrong operation");
                    break;

         }
            Console.Read();
        }

    }
}
