using System;
using System.Runtime.Remoting.Messaging;

namespace ExceptionHandling
{
    class AgeNotValidException : Exception
    {
        public AgeNotValidException(string mes) : base(mes)
        {

        }
    }
    class Customer
    {
        string name;
        int age;
        internal Customer(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public void GetAge()
        {
            try
            {
                if (age > 18)
                {
                    Console.WriteLine("registered");
                }
                else
                {
                    throw new AgeNotValidException("age should be > than 18");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class CustomException
    {
        static void Main()
        {
        Customer customer = new Customer("chandu", 15);
        customer.GetAge();
            Console.Read();
            }
    }
}
