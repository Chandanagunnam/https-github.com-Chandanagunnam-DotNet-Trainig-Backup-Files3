using System;
namespace class_objects
{
    class Employee
    {
        
        string Name; int age; string degree;

        void DisplayDetails()
        {
            Console.WriteLine("Name:{0} || Age:{1} || degree: {2}", Name, age, degree);
        }

        static void Main()
        {
            //object creatn
            Employee objemployee1 = new Employee();
            objemployee1.Name = "akhil";
            objemployee1.age = 26;
            objemployee1.degree = "B.sc";
            objemployee1.DisplayDetails();// display akhil info
            Employee objemployee2 = new Employee();
            objemployee2.Name = "anish";
            objemployee2.age = 29;
            objemployee2.degree = "B.com";
            objemployee2.DisplayDetails();// display anish info
            objemployee1.DisplayDetails();// display akhil info
            Console.Read();

        }
    }
}
