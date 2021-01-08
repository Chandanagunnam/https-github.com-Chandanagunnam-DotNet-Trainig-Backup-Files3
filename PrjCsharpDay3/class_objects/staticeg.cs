using System;

namespace class_objects
{
    class Student
    {
        //static can be accessed by class
        //static cannot be accesed by object
        internal static string collegename;
        string name;
        string dept;
        internal Student(string name,string dept)
        {
            this.name = name;
            this.dept = dept;
        }
        internal void DisplayDetails()
        {
            Console.WriteLine("name: {0} || dept : {1} || CollegeName : {2}", name, dept, collegename);
        }
    }
    class staticeg
    {
        static void Main()
        {
            //accessing static variable by class name
            Console.WriteLine("enter college name");
            Student.collegename = Console.ReadLine();
            string name, dept;
            Console.WriteLine("enter num of studets");
            int num = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[num];
            for(int i = 0; i < student.Length;i++)
            {
                Console.WriteLine("enter name and dept");
                name = Console.ReadLine();
                dept = Console.ReadLine();
                student[i] = new Student(name, dept);
            }
            for(int i = 0; i <student.Length;i++)
            {
                student[i].DisplayDetails();
            }
        }
    }
}
