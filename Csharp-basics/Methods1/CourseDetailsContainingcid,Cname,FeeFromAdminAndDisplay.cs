using System;

namespace Methods1
{
    class CourseDetailsContainingcid_Cname_FeeFromAdminAndDisplay
    {
        void CourseDetails(string Cname, float Fee, int Cid)
        {
       
            Console.WriteLine("The CourseID is {0} for the CourseName {1} and the Fee is {2} in rupees", Cid, Cname, Fee);
        }
        static void Main()
        {
            string CourseName;
            float FeeAmount;
            int CourseID;
            Console.WriteLine("Enter CourseName");
            CourseName = Console.ReadLine();
            Console.WriteLine("Enter Feeamount");
            float.TryParse(Console.ReadLine(), out FeeAmount);
            Console.WriteLine("Enter CourseID");
            CourseID = Convert.ToInt32(Console.ReadLine());
            //object creation
            CourseDetailsContainingcid_Cname_FeeFromAdminAndDisplay ObjCD = new CourseDetailsContainingcid_Cname_FeeFromAdminAndDisplay();
            ObjCD.CourseDetails(CourseName, FeeAmount, CourseID);
            Console.Read();
        }
    } 

}
