using System;

namespace InheritanceP2
{
    
    class InterviewRound1
    {
        internal virtual void Result()
        {
            Console.WriteLine("Round1:cleared 7/10 ");
        }
        public int Score()
        {
            return 7;
        }
    }
    class InterviewRound2 : InterviewRound1
    {
        internal override void Result()
        {
            base.Result();
            Console.WriteLine("Round2:cleared 10/10 ");
        }
        //use of new keyword
        public new int Score()
        {
            return 8;
        }
    }
    class InterviewRound3 : InterviewRound2
    {
        //virtual or abstract class cant be private .. 
        internal override void Result()
        {
            base.Result();
            Console.WriteLine("Round3: not cleared 3/10 ");
        }
        public new int Score()
        {
            return 3;
        }
    }
    class VirtualExample
    {
        static void Main()
        {
            InterviewRound1 r1 = new InterviewRound1();
            r1.Result();
            Console.WriteLine("score {0}", r1.Score());
            InterviewRound2 r2 = new InterviewRound2();
            r2.Result();
            Console.WriteLine("score{0}", r2.Score());

            InterviewRound3 r3 = new InterviewRound3();
            r3.Result();
            Console.WriteLine("score{0}", r3.Score());

            /*InterviewRound3 r3 = new InterviewRound3();
            r3.Result(); */
            Console.Read();

        }
    }
}
    
    

