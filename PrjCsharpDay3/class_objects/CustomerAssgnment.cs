using System;
namespace class_objects
{
    class Customer
    {
        //Create a class called Customer with Customerid, Name, Age, Phone,City. 
        //Write a constructors with no arguments and another constructor with all information.
        //Write a method called DisplayCustomer().
        int Customerid; string Name; int Age; long Phone; string City;
        Customer()
        {
            Console.WriteLine("no arguments");
        }
        Customer(int Customerid, string Name, int Age, long Phone, string City)
        {
            this.Customerid = Customerid;
            this.Name = Name;
            this.Age = Age;
            this.Phone = Phone;
            this.City = City;

        }
        void DisplayCustomer()
        {
            Console.WriteLine("customerid : {0} || name :{1} || age = {2} || phone ={3} || city ={4}",Customerid,Name,Age,Phone,City);

        }
        class CustomerAssgnment
        {
            static void Main()
            {
                Customer [] objcustomer = new Customer[2];
                Customer obj_noarg_customer = new Customer();
                int Customerid; string Name; int Age; long Phone; string City;
                for (int i = 0; i < objcustomer.Length;i++)
                {
                    Console.WriteLine("Customerid, Name, Age, Phone, City");
                    Customerid =Convert.ToInt32( Console.ReadLine());
                    Name = Console.ReadLine();
                    Age = Convert.ToInt32(Console.ReadLine());
                    Phone = Convert.ToInt64(Console.ReadLine());
                    City = Console.ReadLine();
                    objcustomer[i] = new Customer(Customerid, Name, Age, Phone, City);
                }
                for (int i = 0; i < objcustomer.Length; i++)
                {
                    objcustomer[i].DisplayCustomer();
                }
                Console.Read();
            }
        }
    }
}
