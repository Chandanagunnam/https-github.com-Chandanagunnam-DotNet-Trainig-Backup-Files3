using Microsoft.SqlServer.Server;
using System;

namespace Inheritance
{
    //.Create an Interface called ICar which contains the following methods break(),Engine().
    //Create a car company called Benz which implements ICar interface and it also has the method called BenzFunctionality()
    //, Toyota implements ICar interface and it also has the method called ToyotaFunctionality()
    interface ICarExample
    {
        string Brake();
         void Engine();

    }
    class Benz: ICarExample
    {
        public string Brake()
        {
            return "automatic brake";
        }
        public void Engine()
        {
            Console.WriteLine(" benz engine: Automotive");
        }
        internal void BenzFunctionality()
        {
            Console.WriteLine("benz functn: Good gas mileage,Luxurious and intelligent technology");
        }
    }
    class Toyota : ICarExample
    {
        public string Brake()
        {
            return "hydraulic brake";
        }
        public void Engine()
        {
            Console.WriteLine("toyota engine--CRVI");
        }
        internal void ToyotaFunctionality()
        {
            Console.WriteLine(" toyota functn--Good engine Performance  and connectivity ");
        }
    }
    class CarsAssgn
    {
        static void Main()
        {
            Toyota T = new Toyota();
            Benz B = new Benz();
            Console.WriteLine("toyota brake : {0}",T.Brake());
            T.Engine();
            T.ToyotaFunctionality();
            Console.WriteLine("benz brake : {0}",B.Brake());
            B.Engine();
            B.BenzFunctionality();
            Console.Read();

        }
    }
}
