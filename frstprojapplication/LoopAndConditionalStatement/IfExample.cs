using System;

namespace LoopAndConditionalStatement
{
    
        class IfExample
        {
            static void Main()
            {
                int Num1, Num2, Num3;
                Console.WriteLine("Enter Numbers");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Num2 = Convert.ToInt32(Console.ReadLine());
                Num3 = Convert.ToInt32(Console.ReadLine());
                if ((Num1 > Num2) && (Num1 > Num3))
                {
                    Console.WriteLine("Num1 is greater", Num1);
                }
                else if ((Num2 > Num1) && (Num2 > Num3))
                {
                    Console.WriteLine("Num2 is greater", Num2);
                }
                else
                {
                    Console.WriteLine("Num3 is greater", Num3);
                }
                Console.Read();

            }

        }
    }


