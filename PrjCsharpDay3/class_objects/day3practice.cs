using System;
using System.Runtime.InteropServices;

namespace class_objects
{
    class CourseDetails
    {
        int courseid,fees;
        string coursename;
        internal static string institution ;
        internal CourseDetails(int courseid,int fees,string coursename)
        {
            this.courseid = courseid;
            this.fees = fees;
            this.coursename = coursename;
        }
        internal void DisplayCDetails()
        {
            Console.WriteLine("courseid = {0} || fees ={1} || coursename = {2}, || institute = {3}", courseid, fees, coursename,institution);
        }
        static int collegeid = 25607;
        internal static int DisplayCollegeid()
        {
            return collegeid;   
        }
        
    }
    class day3practice
    {
        static void Main()
        {
            Console.WriteLine("enter institn");
            CourseDetails.institution = Console.ReadLine();
            Console.WriteLine("enter size");
            int size = Convert.ToInt32(Console.ReadLine());
            CourseDetails[] objectcd = new CourseDetails[size];
            int courseid, fees;
            string coursename;
            for (int i = 0; i < objectcd.Length; i++)
            {
                Console.WriteLine("enter courseid");
                courseid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter fees");
                fees = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter coursename");
                coursename = Console.ReadLine();
                objectcd[i] = new CourseDetails(courseid, fees, coursename);

            }
            for (int i = 0; i < size; i++)
            {
                objectcd[i].DisplayCDetails();
            }
            Console.WriteLine("college id : {0}",CourseDetails.DisplayCollegeid());
            Console.Read();
        }
                
    }
}
