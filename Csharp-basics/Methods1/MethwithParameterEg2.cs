using System;


namespace Methods1
{
    class MethwithParameterEg2
    {
        
    //Method with Parameters
    
        
            int DisplayAge(int age)
            {
                return (age + 5);
            }


            void DisplayingUserDetails(string cn, string ci, string g, string mail, int a)
            {
                //calling one method from another
                int ag = DisplayAge(a);
                Console.WriteLine("name:{0}||city:{1}||gender:{2}||email:{3}||age{4}", cn, ci, g, mail, ag);

            }
            int Total(int[] marray)
            {
                //loacl to this method
                int sum = 0;
                for (int i = 0; i < marray.Length; i++)
                {
                    sum = sum + marray[i]; //i=0 :0+89=89  //i=1: 89+90//i=2:179+67 ==>246
                }
                return sum;
            }

            static void Main()
            {
                string CName, City, gender, email;
                int[] mark = new int[3] { 89, 90, 67 };
                Console.WriteLine("Enter Cname");
                CName = Console.ReadLine();
                Console.WriteLine("Enter City");
                City = Console.ReadLine();
                Console.WriteLine("Enter gender");
                gender = Console.ReadLine();
                Console.WriteLine("Enter email");
                email = Console.ReadLine();
                
            MethwithParameterEg2 eg2 = new MethwithParameterEg2();
            Console.WriteLine("Enter age");
            int x = Convert.ToInt32(Console.ReadLine());
                int age = eg2.DisplayAge(x);
            eg2.DisplayingUserDetails(CName, City, gender, email, age);
                Console.WriteLine("Sum of Marks is:{0}", eg2.Total(mark));

                Console.Read();
            }
        }
    }

