using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudentCasestudy
{
	class MyApplication
	{
		internal static SqlConnection con = null;
		SqlCommand cmd;
		internal static SqlConnection GetConnection()
		{
			con = new SqlConnection("Data Source= DESKTOP-CDG29PI\\SQLEXPRESS;Initial Catalog=dbStudent;User ID=sa;Password=newuser123#");
			con.Open();
			return con;
		}
	}

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
	class ShowMethods : AppEngine, UserInteraction
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
			var con = MyApplication.GetConnection();
			Console.WriteLine("enter students name");
			string name = Console.ReadLine();
			Console.WriteLine("enter students id");
			int id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter students dob");
			string Dob = Console.ReadLine();
			var cmd = new SqlCommand("StudentRegistration", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@dob", Dob);
			int i = cmd.ExecuteNonQuery();
			Console.WriteLine("Rows Inserted are:{0}", i);
		}
		public void ShowAllCoursesScreen()
		{
			Course[] course = ListOfCourses();
			foreach (var cou in course)
			{
				Info.DisplayCourse(cou);
			}
		}
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
			var con = MyApplication.GetConnection();
			Console.WriteLine("enter course name");
			string name = Console.ReadLine();
			Console.WriteLine("enter course id");
			int id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter course duration");
			int duration = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter course fees");
			float fees;
			float.TryParse(Console.ReadLine(), out fees);
			var cmd = new SqlCommand("AddCourse", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@name", name);
			cmd.Parameters.AddWithValue("@duration", duration);
			cmd.Parameters.AddWithValue("@fees", fees);
			int i = cmd.ExecuteNonQuery();
			Console.WriteLine("Rows Inserted are:{0}", i);

		}

		public void ShowAllStudentsScreen()
		{
			Student[] student = ListOfStudents();
			foreach (var s in student)
			{
				Info.Display(s);
			}
		}

		class Displaying
		{
			public void DisplayStudent()
			{
				var con = MyApplication.GetConnection();
				SqlDataReader dr;
				var cmd = new SqlCommand("select * from StudentDetails", con);
				dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Console.WriteLine(dr["StudentID"] + "   " + dr["StudentName"] + "   " + dr["DOB"]);
				}

			}
			public void DisplayCourses()
			{
				var con = MyApplication.GetConnection();
				SqlDataReader dr;
				var cmd = new SqlCommand("select * from Course", con);
				dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Console.WriteLine(dr["CourseId"] + "   " + dr["CourseName"] + "   " + dr["Duration"] + "   " + dr["fees"]);
				}

			}
			public void DisplayEnrollments()
			{
				var con = MyApplication.GetConnection();
				SqlDataReader dr;
				var cmd = new SqlCommand("select * from Enroll", con);
				dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Console.WriteLine(dr["StudentId"] + "   " + dr["CourseId"] + "   " + dr["DateofEnroll"]);
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
}
