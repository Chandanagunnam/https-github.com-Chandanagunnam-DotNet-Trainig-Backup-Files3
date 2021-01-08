using System;

namespace basiceg
{
    class Calculator
    {
        //global
        float Num1 = 80, Num2 = 20, result;
        //method w/o return type--use void
        void Adding()
        {
            //any variables declared insde this method (Adding()) are local
            //float Num1 = 80, Num2 = 20,result;
            //new space is created for result
            result = Num1 + Num2;
            Console.WriteLine("Addition is {0}",result);
            Console.WriteLine("Addition is {0}", Num1 + Num2);

        }
        //method with return type
        float Subtracting()
        {
            return (Num1 - Num2);
        }

        static void Main()
        {
            //object creation
            //syntax:classname object = newclassname()
            //function f9 key to set breakpoint
            Calculator objcalci = new Calculator();
            objcalci.Adding();
            float res = objcalci.Subtracting();
            //optimized

            Console.WriteLine("Sub:{0}", res);
            Console.WriteLine("Sub:{0}", objcalci.Subtracting());
            Console.ReadKey();
        }
    }
    
    
}
