using System;

namespace Csharp_Basics
{
    class ArrayEx
    {
        static void Main()
        {
            //one dimensional Array
            //syntx1: datatype[] arrayname = new datatype[size];
            //syntx2: datatype[] arrayname = new datatype[size]{};
            //new-- allocates memory
            string[] flower = new string[4];  //0,1,2,3

            flower[0] = "Lily";
            flower[1] = "Rose";
            flower[2] = "tulip";
            flower[3] = "daisy";
            Console.WriteLine(flower[0]);
            for (int i = 0; i < flower.Length; i++)
            {
                Console.WriteLine("index {0}: flower{0} is {1}", i, flower[i]);
            }
            ////taking size and getting marks from readline--- ????
            //int size = 4
            Console.WriteLine("Enter the size of marks array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[size];
            for(int i =0;i < (size);i++)
            {
                Console.WriteLine("Enter marks");
                marks[i] = Convert.ToInt32(Console.ReadLine());

            }

            //example---array values and size from user and displaying the same
            Console.WriteLine("Enter the length of array for animals array");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] Animals = new string[n];
            //for (int i = 0; i < n-1; i++)
            for (int i = 0; i < Animals.Length; i++)
            {
                Console.WriteLine("Enter animal names for {0}",i);
                Animals[i] = Console.ReadLine();
             
            }
            Console.WriteLine("Displaying all animals");
            for (int i = 0; i < Animals.Length; i++)
            {
                Console.WriteLine(Animals[i]);
            }
           Console.Read();
        }
    }
}

        



    
