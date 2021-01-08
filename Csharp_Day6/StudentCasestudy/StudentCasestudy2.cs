using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentCasestudy
{
    class LocalDate
    {
        DateTime EnrollmentDate;
        LocalDate(DateTime EnrollmentDate)
        {
            this.EnrollmentDate = EnrollmentDate;
        }
    }
    public class Enroll
    {
        private Student student { get; set; }
        private Course course { get; set; }
        private LocalDate enrollmentDate { get; set; }
        internal Enroll(Student student, Course course, LocalDate enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
        internal Enroll(Student student, Course course)
        {
            this.student = student;
            this.course = course;
        }

    }

    class AppEngine
    {
        List<Course> cou = new List<Course>();
        void AddingCourses()
        {
            cou.Add(new Course("HTML", 156, 2, 5100));
            cou.Add(new Course("Angular", 158, 5, 8000));
            cou.Add(new Course("Csharp", 160, 6, 8600));


        }
        public void Introduce(Course course)
        {

            cou.Add(course);


        }
        List<Student> stu = new List<Student>();
        public void Register(Student student)
        {
            stu.Add(student);

        }
        List<Enroll> En = new List<Enroll>();
        public void Enroll(Student student, Course course)
        {
            Enroll enroll = new Enroll(student, course);
            En.Add(enroll);

        }
        public Student[] ListOfStudents()
        {
            Student[] student = new Student[stu.Count()];
            foreach (var s in stu)
            {
                int j = 0;
                student[j] = s;
                j++;
            }
            return student;
        }
        public Course[] ListOfCourses()
        {
            Course[] course = new Course[cou.Count()];
            foreach (var c in cou)
            {
                int j = 0;
                course[j] = c;
            }
            return course;
        }
        public Enroll[] ListOfEnrollments()
        {
            Enroll[] enroll = new Enroll[En.Count()];
            foreach (var e in En)
            {
                int j = 0;
                enroll[j] = e;
                j++;
            }
            return enroll;
        }

    }
    class App_Day2
    {
            static void Main()
            {
                AppEngine appEngine = new AppEngine();
                //adding courses
                //Console.WriteLine("enter no. of courses");
                //int cnum = Convert.ToInt32(Console.ReadLine());
                Course course;
                for (int i = 0; i < 5; i++)
                {
                    string name = Console.ReadLine();
                    Console.WriteLine("enter course id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter course duration");
                    int duration = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter course fees");
                    float fees;
                    float.TryParse(Console.ReadLine(), out fees);
                    course = new Course(name, id, duration, fees);
                    appEngine.Introduce(course);
                }
                //adding students
                Console.WriteLine("enter no. of students registered");
                int snum = Convert.ToInt32(Console.ReadLine());
                Student student;
                for (int i = 0; i < snum; i++)
                {
                    Console.WriteLine("enter students name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter students id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter students dob");
                    DateTime Dob = Convert.ToDateTime(Console.ReadLine());
                    student = new Student(name, id, Dob);
                    appEngine.Register(student);

                }
                //enrollment
                Console.WriteLine("enter no. of students to be enrolled");
                int eno = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < eno; i++)
                {
                    Console.WriteLine("enter course name");
                    string cname = Console.ReadLine();
                    Console.WriteLine("enter course id");
                    int cid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter course duration");
                    int duration = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter course fees");
                    float fees;
                    float.TryParse(Console.ReadLine(), out fees);
                    course = new Course(cname, cid, duration, fees);
                    Console.WriteLine("enter students name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter students id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter students dob");
                    DateTime Dob = Convert.ToDateTime(Console.ReadLine());
                    student = new Student(name, id, Dob);
                    course = new Course(cname, cid, duration, fees);
                    appEngine.Enroll(student, course);

                }
            }
    }
}
