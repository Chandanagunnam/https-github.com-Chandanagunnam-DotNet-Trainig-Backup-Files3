using System;


namespace Inheritance
{
    
    class Car:Parts
    {

        static void Main()
        {
            Car c = new Car();
            c.wheel = 4;
            c.motor = "V6";
            c.DisplayParts();
        }
    }
}
