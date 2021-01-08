using System;
namespace Inheritance
{
    
    interface IBreak
    {
        string Break();
    }
    interface IEngine
    {
        string EngineName();
    }
    class Maruthi : IBreak, IEngine
    {
        string IBreak.Break()
        {
            return "applied";
        }
        string IEngine.EngineName()
        {
            return "V6";
        }
    }
        class Carsexample
        {
            static void Main()
            {
                //obj creation--inference 
                IBreak obbreak = new Maruthi();
                Console.WriteLine(obbreak.Break());
                IEngine obengine = new Maruthi();
                Console.WriteLine(obengine.EngineName());

            }
        }
    
}

