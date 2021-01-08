using System;
namespace class_objects
{
    class Movie
    {
        int id;
        string moviename;
        //DateTime year;

        internal Movie(int id, string moviename)
        {
            this.id = id;
            this.moviename = moviename;
            //this.year = year;
        }
        internal void DisplayMovie()
        {
            Console.WriteLine("ID = {0} || MovieName = {1}", id, moviename);
        }
        class ArrayOfObjects
        {
            static void Main()
            {
                Movie movie = new Movie(101, "Robot");
                //array of objects
                //applying array to objects to fetch multiple movie info
                //datatype [] arryname = datatype[size]
                //static
                Console.WriteLine("enter size");
                int size = Convert.ToInt32(Console.ReadLine());
                Movie[] mov = new Movie[size];
                //Movie[] mov = new Movie[2];
                //mov[0] = new Movie(102,"roja");
                //mov[1] = new Movie(103,"Boss");
                int id; string moviename;
                for (int i = 0; i < mov.Length; i++)
                {
                    Console.WriteLine("enter id");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter moviename");
                    moviename = Console.ReadLine();
                    mov[i] = new Movie(id, moviename);
                }
                for (int i = 0; i < mov.Length; i++)
                {
                    mov[i].DisplayMovie();
                }
                Console.Read();
            }
        }
    }
}
