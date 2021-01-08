using System;
namespace LoopAndConditionalStatement
{
    class PrintAllTheAlphabetsFromAToZUsingWhile
    {
        static void Main()
        {
            char alphabet = 'A';
            int i = 1;
            while (i <= 26)
            {
                Console.Write(alphabet);
                i++;
                alphabet++;
            }
            Console.Read();
                }
    }
}
