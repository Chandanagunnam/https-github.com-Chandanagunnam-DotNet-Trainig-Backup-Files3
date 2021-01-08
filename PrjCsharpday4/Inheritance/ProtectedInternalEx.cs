using System;


namespace Inheritance
{
    class Parts
    {
        protected internal int wheel;
        protected internal string motor;
        internal void DisplayParts()
        {
            Console.WriteLine("Wheel ={0},mmotor = {1}", wheel, motor);
        }
    }
    class ProtectedInternalEx
    {
    }
}
