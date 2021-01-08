using System;

namespace basiceg
{
    class AssignAreaOfSquareAndRect
    {
        float side,length,breadth;
        void SquareArea()
        {
            Console.WriteLine("Enter the side in meters");
            
            float.TryParse(Console.ReadLine(), out side);
            Console.WriteLine("Area Of Square is {0} squaremeter", side*side);
        }
        //return method
        float RectangleArea()
        {
            Console.WriteLine("Enter the length and breadth in meters");
            float.TryParse(Console.ReadLine(),out length);
            float.TryParse(Console.ReadLine(), out breadth);
            return (length * breadth);
        }
        static void Main()
        {
            AssignAreaOfSquareAndRect objArea = new AssignAreaOfSquareAndRect();
            objArea.SquareArea();
            Console.WriteLine("Area Of Rectangle is {0} squaremeters", objArea.RectangleArea());
            Console.ReadKey();
        }

    }
}

