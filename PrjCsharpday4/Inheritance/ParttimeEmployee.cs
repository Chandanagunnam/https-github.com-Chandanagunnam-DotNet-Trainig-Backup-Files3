using System;
namespace Inheritance
{
    //Create an Employee class with Empid int, Empname string, Salaryperhour float. 
    //Pass values to the members through Constructor.
    // Create a derived class called ParttimeEmployee with hoursofworking as a data member.
    //Instantiate the base class through the derived class constructor
    //Create a Method called Calculate Salary() based on hoursofworking
    class Employee
    {
        protected int Empid;
        protected string Empname;
        protected float SalaryPerHour;
        protected Employee(int Empid, string Empname, float SalaryPerHour)
        {
            this.Empid = Empid;
            this.Empname = Empname;
            this.SalaryPerHour = SalaryPerHour;
            Console.WriteLine("employee constructor is created");
        }
    }
    class ParttimeEmployee : Employee
    {
        int Hoursofworking;
        ParttimeEmployee(int Empid, string Empname, float SalaryPerHour, int Hoursofworking) : base(Empid, Empname, SalaryPerHour)
        {
            this.Hoursofworking = Hoursofworking;

            Console.WriteLine("parttimeemployee constructor is created");
        }
        float CalculateSalary()
        {
            return (Hoursofworking * SalaryPerHour);
        }
        static void Main()
        {
            ParttimeEmployee objparttimeEmployee = new ParttimeEmployee(101, "Chandana", 562.78f, 8);
            Console.WriteLine("hrs of working {0}",objparttimeEmployee.Hoursofworking);
            Console.WriteLine("salary per hr {0}", objparttimeEmployee.SalaryPerHour);
            Console.WriteLine("emp name {0}", objparttimeEmployee.Empname);
            Console.WriteLine("emp id {0}", objparttimeEmployee.Empid);
            Console.WriteLine("salary {0}", objparttimeEmployee.CalculateSalary());
            Console.Read();

            /*    ParttimeEmployee [] objparttimeEmployee = new ParttimeEmployee[2];
            int Empid; 
            string Empname;
            float SalaryPerHour;
            int Hoursofworking;
            for (int i = 0; i < 2;i++)
            {
                Console.WriteLine("EmployeeID");
                Empid = Convert.ToInt32(Console.ReadLine());
                Empname = Console.ReadLine();
                float.TryParse(Console.ReadLine(), out SalaryPerHour);
                Hoursofworking = Convert.ToInt32(Console.ReadLine());
                objparttimeEmployee[i] = new ParttimeEmployee(Empid, Empname,SalaryPerHour,Hoursofworking);
                objparttimeEmployee[i].CalculateSalary();
                Console.Read();
            } */
        }

    }

    class EmployeeQues
    {

    }
}
