using System;

namespace Inheritance
{
    class College
    {
        protected string CollegeName = "jntuk";
        // protected int Collegeid = 256123;

    }
    class Department : College
    {
        protected string DepartmentName = "cse";
        protected void DisplayDept()
        {
            Console.WriteLine("collegename {0} || departname {1}", CollegeName, DepartmentName);
        }
    }
    class Student : Department
    {
        protected string StudentName = "Siya";
        void DisplayStudent()
        {
            Console.WriteLine("collegename {0} || departname {1} || studentname {2} ||", CollegeName, DepartmentName, StudentName);
        }
        static void Main()
        {
            Student student = new Student();
            student.DisplayDept();
            student.DisplayStudent();
            Console.WriteLine(student.CollegeName);
            Console.WriteLine("dptname is {0} for student {1}", student.DepartmentName, student.StudentName);
            Department dptobj = new Department();
            Console.Read();
        }
    }

    class MultiLevelInheritance
    {
    }
}


