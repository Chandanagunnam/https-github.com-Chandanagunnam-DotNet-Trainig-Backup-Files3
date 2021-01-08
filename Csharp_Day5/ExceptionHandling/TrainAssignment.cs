using System;

namespace ExceptionHandling
{
    //1. Create an console application to book train tickets. 
     // Create a Passanger class with (Name, Age) and write a function called TicketBooking(no_of_tickets)
    //that takes no.of tickets to be booked.
    //If the no of tickets is > 2 per booking, raise an user defined exception, and print "cannot book more than 2 tickets". 
     //Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.
    class TicketLimitException : Exception
    {
       internal TicketLimitException(string message):base(message)
        {
            
        }
    }
    class Passenger
    {
        string Name;
        int Age;
        internal Passenger(string Name,int Age)
        {
            this.Age = Age;
            this.Name = Name;
        }
       internal void TicketBooking(int no_of_tickets)
        {
            Console.WriteLine("Status of Train Booking by {0}", Name);
            try
            {
                if (no_of_tickets > 2)
                {
                    throw new TicketLimitException("cannot book more than 2 tickets");
                }
                else
                {
                    Console.WriteLine("Ticket Booked Successfully");
                }
            }
            catch(Exception ex )
            {
                Console.WriteLine("Message : {0}",ex.Message);
            }
            

        }
        class Testclass
        {
            static void Main()
            {
                Passenger passenger = new Passenger("Mary",15);
                passenger.TicketBooking(1);
                passenger.TicketBooking(5);
                Console.Read();
            }
        }

    }
    class TrainAssignment
    {
    }
}
