using System;
namespace Csharp_Basics
{
    class BoxingandUnBoxing
    {
        static void Main()
        {
            //converting value type to reference type--boxing
            //value type
            int petrol = 1;
            //reference type
            object oil = petrol;
            Console.WriteLine("converting value type to reference type--boxing: {0} to {1}", petrol, oil);
            //converting reference type to value type--unboxing
            //reference type
            string diesel = "15";
            //valuetype
            int price = Convert.ToInt32(diesel);
            Console.WriteLine("converting reference type to value type--unboxing: {0} to {1}", diesel, price);
            Console.Read();


        }
    }
}
