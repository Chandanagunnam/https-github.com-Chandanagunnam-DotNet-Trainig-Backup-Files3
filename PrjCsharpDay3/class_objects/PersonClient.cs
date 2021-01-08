using System;
namespace class_objects
{
    class PersonClient
    {
        static void Main()
        {
            //creating object for Person class in PersonClient class
            // internal--- access information inside the project i.e. class_objects project
            Person objperson = new Person();
            objperson.name = "RaviTeja";
            objperson.age = 40;
            //methods are internal...but in person class we made DisplayPerson() as internal..so we can access that method here
            objperson.DisplayPerson();
            Console.Read();
        }
    }
}
