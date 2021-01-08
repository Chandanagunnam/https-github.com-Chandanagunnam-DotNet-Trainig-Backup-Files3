using System;
namespace basiceg
{
    class InputFromUseEg
    {
        static void Main()
        {
            string Name, City;
            int Age;
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine(); //Console.Read();//input from user
            Console.WriteLine("Enter city");
            City = Console.ReadLine();
            Console.WriteLine("Enter age");
            //converting int to string--readline reads only string
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name is {0} | city is {1}| age is {2}", Name, City, Age);
            Console.Read();
        }
    }
}
