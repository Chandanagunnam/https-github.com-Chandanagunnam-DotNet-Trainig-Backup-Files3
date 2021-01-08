using System;

namespace Csharp_Basics
    //enum can be declared inside or outside the class
{
    enum Feedback
    {
        poor, good, verygood, excellent
    }
    enum Months
    {
        Jan = 1,Feb,Mar,Apr,May
    }
    class EnumerationExample
    {
        static void Main()
        {
            String EmpName = "Suriya";
            Enum fd = Feedback.excellent;
            Console.WriteLine(fd);
            Console.WriteLine("Rating for {0} is {1}", EmpName, Feedback.good);
            //value stored in good i.e. 1 (to get value we convert)
            Console.WriteLine("Rating for {0} is {1}", EmpName, (int)Feedback.good);
            Console.WriteLine("Birthmonth for {0} is {1}", EmpName, Months.Jan);
            Console.WriteLine("Birthmonth for {0} is {1} i,e {2}", EmpName, Convert.ToInt32(Months.Mar), Months.Mar);
            Console.Read();




        }
    }
}
