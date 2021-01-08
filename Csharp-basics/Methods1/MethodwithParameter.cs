using System;
namespace Methods1
{
    //method with parametres
    class MethodwithParameter
    {
        void DisplayUserDetails(string cn, string ci, string gend, string mail)
        {
            Console.WriteLine("name:{0}||city:{1}||gender:{2}||email:{3}", cn, ci, gend, mail);
        }
        int Total(int[] mar)
        {
            //sum is locat to method
            int sum = 0;
            for(int i = 0;i < mar.Length;i++)
            {
                sum = sum + mar[i];
            }
            return sum;
        }
        static void Main()
        {
            string Cname, City, gender, email;
            int[] marks = new int[3] { 89, 90, 67 };
            Console.WriteLine("Enter Cname");
            Cname = Console.ReadLine();
            Console.WriteLine("Enter City");
            City = Console.ReadLine();
            Console.WriteLine("Enter Gnder");
            gender = Console.ReadLine();
            Console.WriteLine("Enter Email");
            email = Console.ReadLine();
            MethodwithParameter eg = new MethodwithParameter();
            eg.DisplayUserDetails(Cname, City, gender, email);
            Console.WriteLine("Sum of marks is:{0}", eg.Total(marks));
            Console.Read();
        }
    }


}
