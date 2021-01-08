using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Student
    {
        public string name { get; set; }
        public int id { get; set; }
        public int age { get; set; }
        public Student(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
    } 
    class BusinessLayer
    {
        public void Displaycity(string c)
        {
            Console.WriteLine("City {0}", c);
        }
        public void DisplayStudentDetails(List<Student> stu)
        {
            if(stu.Count!=0)
            {
                foreach(Student s in stu)
                {
                    if (s.name != null && s.age != 0 && s.id != 0)
                        Console.WriteLine("id {0} || name {1} || age {2}", s.id, s.name, s.age);
                    else
                        Console.WriteLine("Some Values are null or 0 in input.give valid input");
                }
            }
            else
            {
                Console.WriteLine("empty list");
            }
        }
    }


    class Scenarioeg
    {
        static void Main()
        {
            string city = "madras";
            List<Student> student = new List<Student>();
            student.Add(new Student("vasu", 106534, 29));
            student.Add(new Student("marina", 886534, 32));
            student.Add(new Student("Neel", 0, 29));
            student.Add(new Student(null, 108324, 29));
            BusinessLayer businessLayer = new BusinessLayer();
            businessLayer.Displaycity(city);
            businessLayer.DisplayStudentDetails(student);
           /* foreach(Student s in student)
            {
                Console.WriteLine(s.name + "  " + s.age + " " + s.id);
                Console.WriteLine("id {0} || name {1} || age {2}", s.id, s.name, s.age);

            }*/
            Console.Read();


        }
    }
}
