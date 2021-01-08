using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Non_GenericCollectionEg
{
    class StackAndQueue
    {
        static void Main()
        {
            //stack -first IN last OUT (stack of books)
            Stack s = new Stack();
            s.Push("Anu");
            s.Push(56);
            s.Push("sravan");
            s.Push(35.23);
            foreach(Object item in s)
            {
                Console.WriteLine("items {0}", item);

            }
            //popping
            Console.WriteLine("popped 1 item {0}", s.Pop());
           //peeking-which element is on top of stack
            Console.WriteLine("peek :{0}", s.Peek());
            foreach (Object item in s)
            {
                Console.WriteLine("items {0}",item);

            }
            Console.WriteLine("--Queue-----");
            //first IN first OUT
            Queue Q = new Queue();
              // Enque () adds an object to que
            Q.Enqueue( "sagar");
            Q.Enqueue("manasa");
            Q.Enqueue("vinod");
            Q.Enqueue("bhavya");
            Console.WriteLine("count in q {0}",Q.Count);
            foreach (Object item in Q)
            {
                Console.WriteLine("items {0}", item);

            }
            //dequeue -removes first object in que
            Console.WriteLine("Removed item {0}", Q.Dequeue());
            //peek
            Console.WriteLine("Peek item {0}", Q.Peek());
            foreach (Object item in Q)
            {
                Console.WriteLine("items {0}", item);

            }
            Console.Read();





        }
    }
}
