using System;
namespace class_objects
{
    class Shape
    {
        internal double Area(int r)
        {
            return (3.14 * r * r);
        }
        internal int Area(int l,int b)
        {
            return l * b;
        }
    }
    class MethodoverloadingEg
    {
        static void Main()
        {
            Shape shape = new Shape();
            Console.WriteLine("enter radius");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter length");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");
            int brd = Convert.ToInt32(Console.ReadLine());
            //overloading of methods--
            Console.WriteLine("Circle area = {0}", shape.Area(rad));
            Console.WriteLine("Rectangle area = {0}", shape.Area(len,brd));
            Console.Read();

        }
    }

    }

