using System;
namespace LoopAndConditionalStatement
{
    //SOLVE ??/??????
    class Palindrome
    {
        static void Main()
        {
            Console.WriteLine("Enter the word");
            string Palindrome = Console.ReadLine();
            int len = Palindrome.Length,i = 0;
            while(i <= len - 1)
            {
                if (Palindrome[i] == Palindrome[len - 1])
                {
                    i++;
                    len--;
                }


            }
            Console.Write("It is Palindrome");



            Console.Read();
        }
    }
}
