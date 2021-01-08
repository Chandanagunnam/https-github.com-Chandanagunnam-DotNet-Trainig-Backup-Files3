using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCasestudy
{
    //Case Study Plan - 
    //Create Student class (id, name, dateofbirth) 
    //- Cover constructors, getters and setters -
    public class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime Dob { get; set; }
        public Student(string Name, int Id, DateTime Dob)
        {
            this.Name = Name;
            this.Id = Id;
            this.Dob = Dob;
        }
    }
    //create Course class on their own(id, name, duration, fees)
    public class Course
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public float fees { get; set; }
        public int Duration { get; set; }
        public Course(string Name,int Id,int Duration,float fees)
        {
            this.Duration = Duration;
            this.fees = fees;
            this.Id = Id;
            this.Name = Name;

        }
    }
    //Create class Info - Write a method called as:
    //public void display(Student student)
    //{ //Code here to display the details of given student }
    public class Info
    {                   //datatype-Student i.e, class
                        //variable -stu
        public static void Display(Student stu)
        {
            Console.WriteLine("Name:{0}, Id :{1}, Dob:{2}", stu.Name, stu.Id, stu.Dob);

        }
        public static void DisplayCourse(Course course)
        {
            Console.WriteLine("Name:{0}, Id :{1}, Duration :{2},Fees :{3} ", course.Name, course.Id, course.Duration,course.fees);
        }
        public static void DisplayEnrollments(Enroll enroll)
        {
            AppEngine appEngine = new AppEngine();
           Console.WriteLine("List of enrollments are {0}",appEngine.ListOfEnrollments());
        }
       
    }
    //- Create App class with main method. 
    //Then - Write a method called as
    //scenario1 to: - Create few objects of Student class -
    //Call the display method of Info class - 
    class App_Day1
    {
        static void Main()
        {
            //Info info = new Info();

            
                Student s1 = new Student("Radha", 150, Convert.ToDateTime("12/12/2005"));

                Student s2 = new Student("Madhuri", 180, Convert.ToDateTime("26/08/2015"));

                Info.Display(s1);
                Info.Display(s2);
            

            //Write a method called as scenario2 to: 
            //- Create array of Student class and store few objects in it - Demonstrate how to iterate over the array and call the display method for each student -

            Student[] s3 = new Student[2];
            s3[0] = new Student("Sonal", 189, Convert.ToDateTime("18/07/2011"));
            s3[1] = new Student("siya", 149, Convert.ToDateTime("16/12/2001"));
            for (int i = 0; i < 2; i++)
            {
                Info.Display(s3[i]);
            }

            //Write a method called as scenario3 to: - Take Student data as input from the user, store it in Student object -
            //Repeat the above process using loops - Use Arrays to store the Student objects as covered in scenario2 - Finally iterate over the array to display all the collected data

            Console.WriteLine("enter no. of students");
            int num = Convert.ToInt32(Console.ReadLine());
            Student[] s4 = new Student[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("enter students name");
                string name = Console.ReadLine();
                Console.WriteLine("enter students id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter students dob");
                DateTime Dob = Convert.ToDateTime(Console.ReadLine());
                s4[i] = new Student(name, id, Dob);
                Info.Display(s4[i]);
            }

        }
    }
}

    
