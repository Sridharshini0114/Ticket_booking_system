namespace Ticket_Booking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region    Task 1
            //Task 1
            //Console.WriteLine("Enter the no of available tickets: ");
            //int availableTickets = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the no of tickets you want to book: ");
            //int BookingTickets = Convert.ToInt32(Console.ReadLine());

            //if (BookingTickets <= availableTickets)
            //{

            //    int remainingTickets = availableTickets - BookingTickets;
            //    Console.WriteLine($"Booking Successful! {BookingTickets} tickets booked.");
            //    Console.WriteLine($"Remaining tickets: {remainingTickets}");
            //}
            //else
            //{

            //    Console.WriteLine("Sorry, ticket unavailable. ");
            //}
            #endregion

            #region  Task 2
            //Task 2

            //Console.WriteLine("Welcome to the Ticket Booking System!");
            //Console.WriteLine("Please choose your ticket category:");
            //Console.WriteLine("1. Silver");
            //Console.WriteLine("2. Gold");
            //Console.WriteLine("3. Diamond");

            //Console.Write("Enter the number corresponding to the ticket category: ");
            //int ticketCategory = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the number of tickets you want to book: ");
            //int numberOfTickets = Convert.ToInt32(Console.ReadLine());
            //decimal ticketPrice = 0;
            //decimal totalCost = 0;
            //if (ticketCategory == 1)
            //{

            //    ticketPrice = 100; 
            //    Console.WriteLine("You selected Silver tickets. The price per ticket is $100.");
            //}
            //else if (ticketCategory == 2)
            //{

            //    ticketPrice = 200; 
            //    Console.WriteLine("You selected Gold tickets. The price per ticket is $200.");
            //}
            //else if (ticketCategory == 3)
            //{

            //    ticketPrice = 500; 
            //    Console.WriteLine("You selected Diamond tickets. The price per ticket is $500.");
            //}
            //else
            //{

            //    Console.WriteLine("Invalid ticket category selected. ");
            //    return; 
            //}
            //totalCost = ticketPrice * numberOfTickets;


            //Console.WriteLine($"The total cost for {numberOfTickets} ticket(s) is: ${totalCost}");
            #endregion

            #region  Task 3
            //task 3
            Console.WriteLine("Welcome to the Ticket Booking System!");
            Console.WriteLine("Ticket Categories:");
            Console.WriteLine("1. Silver - $50");
            Console.WriteLine("2. Gold - $100");
            Console.WriteLine("3. Diamond - $200");

            while (true)
            {
                Console.WriteLine("\nEnter ticket category (Silver, Gold, Diamond) or type 'Exit' to quit:");
                string category = Console.ReadLine();

                if (category == "Exit")
                {
                    Console.WriteLine("Thank you for using the Ticket Booking System!");
                    break;
                }

                decimal price = 0;
                if (category == "Silver") price = 50;
                else if (category == "Gold") price = 100;
                else if (category == "Diamond") price = 200;
                else
                {
                    Console.WriteLine("Invalid category. Try again.");
                    continue;
                }

                Console.WriteLine("Enter the number of tickets:");
                int tickets = int.Parse(Console.ReadLine());

                decimal totalCost = price * tickets;
                Console.WriteLine($"You booked {tickets} {category} ticket(s). Total cost: ${totalCost}");
            }
            #endregion





        }
    }
}
