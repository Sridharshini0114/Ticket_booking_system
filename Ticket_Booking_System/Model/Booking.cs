

namespace Ticket_Booking_System.Model
{
    internal class Booking
    {
        // Attributes
        public Event EventDetails { get; set; }
        public int NumberOfTickets { get; set; }
        public decimal TotalCost { get;  set; }

        // Default Constructor
        public Booking()
        {
            
        }

        // Parameterized Constructor
        public Booking(Event eventDetails)
        {
            EventDetails = eventDetails;
            NumberOfTickets = 0;
            TotalCost = 0;
        }

        // Calculate the booking cost
        public decimal CalculateBookingCost(int numTickets)
        {
            TotalCost = numTickets * EventDetails.TicketPrice;
            return TotalCost;
        }

        // Book tickets for the event
        public bool BookTickets(int numTickets)
        {
            if (EventDetails.BookTickets(numTickets))
            {
                NumberOfTickets += numTickets;
                CalculateBookingCost(numTickets);
                Console.WriteLine($"Booking successful! Total cost: {TotalCost:C}");
                return true;
            }
            return false;
        }

        // Cancel tickets for the event
        public bool CancelBooking(int numTickets)
        {
            if (EventDetails.CancelBooking(numTickets))
            {
                NumberOfTickets -= numTickets;
                CalculateBookingCost(-numTickets);
                Console.WriteLine($"Booking cancellation successful! Updated cost: {TotalCost:C}");
                return true;
            }
            return false;
        }

        // Get available tickets for the event
        public int GetAvailableNoOfTickets()
        {
            return EventDetails.AvailableSeats;
        }

        // Get event details
        public void GetEventDetails()
        {
            EventDetails.DisplayEventDetails();
        }
    }
}
