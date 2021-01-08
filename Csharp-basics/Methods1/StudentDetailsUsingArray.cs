using System;

namespace Methods1
{
    class StudentDetailsUsingArray
    {
        //get student details contains name,age,marks (using array).
        //Get minimum 5 subject marks.
        //calculate grade in separate method called calculategrade() by passing marks as input to this method.
        //Based on grade scored display the feedback.Store feedback in enumeration.
        //Display student name , grade and feedback in DisplayResultMethod().
        enum Feedback
        {
            Excellent, Good, Average, Poor
        }
        void Calculategrade(int[] marks)
        {
            float percent;
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum = marks[i] + sum;
            }

            percent = sum / (marks.Length);
            Char Grade;
            Enum feed;
            if (percent <= 35)
            {
                Grade = 'D';
                feed = Feedback.Poor;
            }
            else if(percent >35 & percent<50)
                {
                 Grade = 'C';
                feed = Feedback.Average;

            }
            else if (percent > 60 & percent < 80)
            {
                Grade = 'B';
                feed = Feedback.Good;

            }
            else
            {
                 Grade = 'A';
                feed = Feedback.Excellent;

            }
            Console.WriteLine("Grade {0}, Feedback {1}", Grade, feed);

        }
       
       /* Enum FeedBack(Char Gr, int[] mark)
        {
            Enum fd;
            Gr = Calculategrade(mark);
            if (Gr == 'D')
            {
                return fd = Feedback.Poor;
            }
            else if (Gr == 'C')
            {
                return fd = Feedback.Average;
            }
            else if (Gr == 'B')
            {
                return fd = Feedback.Good;
            }
            else
            {
                return fd = Feedback.Excellent;

            }
        }*/
        void DisplayResultMethod(string sname, int[] mar,int ag)
        {
            Calculategrade(mar);
           
            Console.WriteLine("Student Name :{0},Age:{1},", sname, ag);
        }

        static void Main()
        {
            Console.WriteLine("enter size of marks");
            int s = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[s];
            Console.WriteLine("enter marks");
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter student name");
            string student = Console.ReadLine();
            Console.WriteLine("enter student age");
            int age = Convert.ToInt32(Console.ReadLine());
            StudentDetailsUsingArray obSD = new StudentDetailsUsingArray();
            obSD.DisplayResultMethod(student, m,age);
            Console.Read();

        }
    }

}
