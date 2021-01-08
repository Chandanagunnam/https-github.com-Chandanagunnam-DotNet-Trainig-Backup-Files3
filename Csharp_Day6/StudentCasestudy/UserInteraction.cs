using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace StudentCasestudy
{
	interface UserInteraction
	{
		void ShowFirstScreen();//
		
	    void ShowStudentScreen();//
		void ShowAdminScreen();//
		void ShowAllStudentsScreen();//
		void ShowStudentRegistrationScreen(); // Execute the register method of AppEngine class
		void IntroduceNewCourseScreen();
		void ShowAllCoursesScreen();//

	}
	class ShowMethods : AppEngine,UserInteraction
	{
		public void ShowFirstScreen()
		{
			Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
			Console.WriteLine("Tell us who you are : 1. Student 2. Admin");
			Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
			//Scanner scanner = new Scanner(System.in);
			int op = Convert.ToInt32(Console.ReadLine());
			switch (op)
			{
				case 1:
					ShowStudentScreen();
					break;
				case 2:
					ShowAdminScreen();
					break;
			}
		}
		public void ShowStudentScreen()
		{
			Console.WriteLine("Welcome to Student Portal");
			Console.WriteLine("Enter 1 for StudentRegistration");
			Console.WriteLine("Enter 2 for ListOfLAllCourses ");
			//Scanner scanner = new Scanner(System.in);
			int op = Convert.ToInt32(Console.ReadLine());
			switch (op)
			{
				case 1:
					ShowStudentRegistrationScreen();
					break;
				case 2:
					ShowAllCoursesScreen();
					break;
			}
		}
		public void ShowStudentRegistrationScreen()
		{
			Console.WriteLine("enter students name");
			string name = Console.ReadLine();
			Console.WriteLine("enter students id");
			int id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter students dob");
			DateTime Dob = Convert.ToDateTime(Console.ReadLine());
			Student student = new Student(name, id, Dob);
			Register(student);
		}
		public void ShowAllCoursesScreen()
		{
Course[] course = ListOfCourses();
			foreach (var cou in course)
			{
				Info.DisplayCourse(cou);
			}		}
		public void ShowAdminScreen()
        {
			Console.WriteLine("Welcome to Admin Portal");
			Console.WriteLine("Enter 1 for All Students Details");
			Console.WriteLine("Enter 2 for Introducing new course ");
			//Scanner scanner = new Scanner(System.in);
			int op = Convert.ToInt32(Console.ReadLine());
			switch (op)
			{
				case 1:
					ShowAllStudentsScreen();
					break;
				case 2:
					IntroduceNewCourseScreen();
					break;
			}

		}
		public void IntroduceNewCourseScreen()
        {
			Console.WriteLine("enter no. of courses to be introduced");
			int cnum = Convert.ToInt32(Console.ReadLine());
			Course course;
			for (int i = 0; i < cnum; i++)
			{
				Console.WriteLine("enter course name");
				string name = Console.ReadLine();
				Console.WriteLine("enter course id");
				int id = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter course duration");
				int duration = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter course fees");
				float fees;
				float.TryParse(Console.ReadLine(), out fees);
				course = new Course(name, id, duration, fees);
				Introduce(course);
			}
		}
		public void ShowAllStudentsScreen()
        {
			Student[] student = ListOfStudents();
			foreach (var s in student)
			{
				Info.Display(s);
			}
        }
	}
	class App_Day3
    {
		static void Main()
        {
			ShowMethods showMethods = new ShowMethods();
			showMethods.ShowFirstScreen();
			Console.Read();
        }
    }
}
*/

