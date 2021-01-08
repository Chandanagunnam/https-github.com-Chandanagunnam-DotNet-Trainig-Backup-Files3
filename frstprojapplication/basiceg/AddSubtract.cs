using System;

namespace basiceg
{
    class AddSubtract
    {
            static void Main()
            {
                int Num1 = 10, Num2 = 20, result;
            //* donot declare multiple variable with samename and same datatype
                result = Num1 + Num2;
            Console.Write("Addition Example :");
            Console.WriteLine("Addition Of {1} and {0} is {2}", Num1, Num2, result);

            //Subtraction (result variable used two times for difft opertions)
            Console.WriteLine("Subtraction Exaample :");
            result = Num1 - Num2;
            Console.WriteLine("Subtracting {1} from {0} is {2}", Num1, Num2, result);

            // arithematic opertions inside the console.write
            
            Console.WriteLine("Subtracting {0} from {1} is {2}", Num1, Num2, result = Num2 - Num1);
            
            //if we use multiple readkey() only the first readkey executed 
            Console.WriteLine("Multiplication Example:");
            Console.WriteLine("{0}*{1} is {2}", Num1, Num2,Num1 * Num2);
            Console.ReadKey();

        }
    }
}
