using System;
using System.Threading;

namespace Csharp_Basics
{
    class FrequencyOfElementsInArray
    {
        //Find the frequency of an given elements in an array eg:{2,3,5,2,3,2} 
        //Input: 2 output: frequency of 2 is 3
        static void Main()
        {
            Console.WriteLine("enter the size of array set");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Set = new int[size];
            for (int i = 0;i < size;i++)
            {
                Console.WriteLine("enter numbers in set");
                Set[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= size-1; i++)
            {
                Console.WriteLine(Set[i]);
            }

            Console.WriteLine("enter the number for which frequency to be checkd");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if(num == Set[i])
                {
                    count++;
                }
                
            }
            Console.Write("frequency of {0} is {1}", num, count);
            Console.Read();
        }

    }
}
