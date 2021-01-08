using System;
namespace Inheritance
{
    // Create an Abstract class Student with Name, StudentId, Grade as members
    //and also an abstarct method Boolean Ispassed(grade) which takes grade as an input and 
    //checks whether student passed the course or not.
    //Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student 
    //and overrides Ispassed() method
    //For the UnderGrad class, if the grade is above 70.0, then isPassed returns true,
    //otherwise it returns false. 
    //For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false.
    
        abstract class Students
        {
           internal string Name = "Swara";
        internal int StudentId = 85996;
            internal float grade;
        public abstract Boolean Ispassed(float grade);
            
        }
        class Undergraduate:Students
        {
        public override  Boolean Ispassed(float grade)
        {
            if (grade > 70.0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        }
    class Graduates:Students
    {
        public override Boolean Ispassed(float grade)
        {
            if (grade > 80.0f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    class AbstractionStudent
    { 
        static void Main()
        {
            /* Students students;
            Console.WriteLine("data for undergradute students");
            students = new Undergraduate();
            Console.WriteLine("enter grade studentname and id");
            float.TryParse(Console.ReadLine(), out students.grade);
            students.Name = Console.ReadLine();
            students.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Undergraduate:  studentname ={0}||id ={1}||grade {2}||is passed {3}",students.Name,students.StudentId,students.grade,students.Ispassed(students.grade));
            Console.WriteLine("data for gradute students");
            students = new Graduates();
            Console.WriteLine("enter grade studentname and id");
            float.TryParse(Console.ReadLine(), out students.grade);
            students.Name = Console.ReadLine();
            students.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Graduates:   studentname ={0}||id ={1}||grade {2}||is passed {3}", students.Name, students.StudentId, students.grade, students.Ispassed(students.grade));
            Console.Read();
            */

            /*
            Undergraduate u = new Undergraduate();
            Graduates g = new Graduates();
            Console.WriteLine("Graduate:   studentname ={0}||id ={1}||grade {2}||is passed {3}",g.Name,g.StudentId,g.grade, g.Ispassed(g.grade));
            Console.WriteLine("Under-Graduate:   studentname ={0}||id ={1}||grade {2}||is passed {3}", g.Name, g.StudentId, g.grade, u.Ispassed(g.grade));

            Console.Read(); */
            
            //refering abstract class
            Students students;
            students = new Undergraduate();
            students.grade = 75.0f;
            Console.WriteLine("Under-Graduate:studentname ={0},id ={1},grade {2},is passed {3}", students.Name, students.StudentId, students.grade, students.Ispassed(students.grade));

            students = new Graduates();
            students.grade = 78.5f;

            Console.WriteLine("Graduate:   studentname ={0},id ={1},grade {2},is passed {3}", students.Name, students.StudentId, students.grade, students.Ispassed(students.grade));
            Console.Read();


        }
    }
}
