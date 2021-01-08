using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class TicketLimitException : Exception
    {
        internal TicketLimitException(string message) : base(message)
        {

        }
    }
    class Day6Train
    {
        static void Main()
        {
            string Trainname = "Rajadhani Express";
            int TrainNo = 159634;
            int AvailableTickets = 100;
            int k;
        
            do
            {
                Console.WriteLine("     ");
                Console.WriteLine("Hi Customer,Enter the Number to select the options");
                Console.WriteLine("Enter 1 to see AvailableTickets");
                Console.WriteLine("Enter 2 to  BookTickets");
                Console.WriteLine("Enter 3 to  exit from the application");
                k = Convert.ToInt32(Console.ReadLine());

                switch (k)
                {
                    case 1:
                        {
                            Console.WriteLine("AvailableTickets for {1} {2} are {0}", AvailableTickets,TrainNo,Trainname);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Num of Tickets");
                            int no_of_tickets = Convert.ToInt32(Console.ReadLine());

                            try
                            {
                                if(no_of_tickets == 0)
                                {
                                    Console.WriteLine("Cannot book 0 tickets");
                                }

                                else if (no_of_tickets > 2)
                                {
                                    throw new TicketLimitException("Dear Customer,You cannot book more than 2 tickets");
                                }
                               
                                else
                                {
                                    Console.WriteLine("Enter the PassengerName");
                                    string PName = Console.ReadLine();
                                    Console.WriteLine("Ticket Booked Successfully");
                                    Console.WriteLine("PassengerName {0},Train No {1},Train Name {3},num of tickets {2}", PName, TrainNo, no_of_tickets, Trainname);
                                    AvailableTickets = AvailableTickets - no_of_tickets;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine( ex.Message);
                            }

                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Thank You !!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Dear Customer,You have entered an invalid option.Kindly, Enter 1 or 2 or 3");
                        }
                        break;


                }

                
            } while ( k != 3);

            Console.Read();
        }
    }
}