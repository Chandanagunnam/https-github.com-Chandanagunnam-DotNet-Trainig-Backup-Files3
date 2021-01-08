using System;

namespace Inheritance
{
    class College1
    {
        protected string id = "C101";
        //protected string CollegeName = "jntuk";
        protected string CollegeName;
        //constructor
        internal College1(string CollegeName)
        {
            this.CollegeName = CollegeName;
            Console.WriteLine("College Costructor");
        }
        ~College1()
        {
            Console.WriteLine("College Destructor");

        }

    }
    class Department1 : College1
    {
        string id = "D563";
        //protected string DepartmentName = "cse";
        protected string DepartmentName;
        //constructor
        internal Department1(string Cname,string DepartmentName):base(Cname)
        {
            this.DepartmentName = DepartmentName;
            Console.WriteLine("Departmt Costructor");
        }
        protected void DisplayDept()
        {
            Console.WriteLine("collegeid {0} || departid {1}", base.id, id);
            Console.WriteLine("collegename {0} || departname {1}", CollegeName, DepartmentName);
        }
        ~Department1()
        {
            Console.WriteLine("Departmt destructor");

        }
    }
    class Student1 : Department1
    {
        // protected string StudentName = "Siya";
        string StudentName;
        //constructor
        internal Student1(string Cname, string Dname, string StudentName) : base(Cname,Dname)
        {
            this.StudentName = StudentName;
            Console.WriteLine("Student Costructor");
        }
        void DisplayStudent()
        {
            Console.WriteLine("collegename {0} || departname {1} || studentname {2} ||", CollegeName, DepartmentName, StudentName);
        }
        
        static void Main()
        {
            Student1 student = new Student1("JNTU","MBA","Vinni");
            student.DisplayDept();
            student.DisplayStudent();
            Console.WriteLine(student.CollegeName);
            Console.WriteLine("dptname is {0} for student {1}", student.DepartmentName, student.StudentName);
            Department dptobj = new Department();
            Console.Read();
            GC.Collect();
        }
        ~Student1()
        {
            Console.WriteLine("Student Destructor");

        }
    }
    class Constrcutor_inheritance
    {
    }

}





