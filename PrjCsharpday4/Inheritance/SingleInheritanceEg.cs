using System;


namespace Inheritance
{
    class Organization//parent or base class
    {
        //protected--only child class cn acces the information
       protected string Orgname;
        string location = "Mumbai";
       protected void DisplayOrg()
        {
            Console.WriteLine("orgname {0}, location {1}", Orgname, location);
        }
        //Inheritance(child or derived class: parent class)
        class Employee:Organization
        {
            int employeeid = 10653409;
            float salaryperhr = 1500.56f;
            void DisplayEmployee()
            {
                //DisplayOrg()
                Console.WriteLine("employeeid {0}, salary {1},location {2}", employeeid,salaryperhr,location);

            }
            static void Main()
            {
                //Organization organization = new Organization();
                //organization.DisplayOrg();
                Employee employee = new Employee();
                //access parent class info with child class object
                employee.Orgname = " LTI";
                employee.DisplayOrg();
                employee.DisplayEmployee();
                Console.Read();

            }
        }

    }

    class SingleInheritanceEg
    {
        //to access in other class --- use internal 
    }
}
