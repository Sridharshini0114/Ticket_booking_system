

namespace Ticket_Booking_System.Model
{
    internal class Event:Repository.IEvent
    {

        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }
        public string VenueName { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public decimal TicketPrice { get; set; }
        public EventType EventType { get; set; }

        //default constructor
        public Event()
        {
             
        }

        //parameterized constructor
        public Event(string eventName, DateTime eventDate, TimeSpan eventTime, string venueName, int totalSeats, decimal ticketPrice, EventType eventType)
        {
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            VenueName = venueName;
            TotalSeats = totalSeats;
            AvailableSeats = totalSeats;
            TicketPrice = ticketPrice;
            EventType = eventType;
        }

        public decimal CalculateTotalRevenue()
        {
            int bookedTickets = TotalSeats - AvailableSeats;
            return bookedTickets * TicketPrice;
        }
        public int GetBookedNoOfTickets()
        {
            return TotalSeats - AvailableSeats;
        }
        public bool BookTickets(int numTickets)
        {
            if (numTickets > AvailableSeats)
            {
                Console.WriteLine("Not enough seats available.");
                return false;
            }

            AvailableSeats -= numTickets;
            Console.WriteLine($"{numTickets} tickets booked successfully.");
            return true;
        }
        public bool CancelBooking(int numTickets)
        {
            if (numTickets > (TotalSeats - AvailableSeats))
            {
                Console.WriteLine("Cannot cancel more tickets than booked.");
                return false;
            }

            AvailableSeats += numTickets;
            Console.WriteLine($"{numTickets} tickets canceled successfully.");
            return true;
        }

        // Display event details
        public void DisplayEventDetails()
        {
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate:yyyy-MM-dd}");
            Console.WriteLine($"Event Time: {EventTime}");
            Console.WriteLine($"Venue Name: {VenueName}");
            Console.WriteLine($"Total Seats: {TotalSeats}");
            Console.WriteLine($"Available Seats: {AvailableSeats}");
            Console.WriteLine($"Ticket Price: {TicketPrice:C}");
            Console.WriteLine($"Event Type: {EventType}");
        }

    }
    public enum EventType
    {
        Movie,
        Sports,
        Concert
    }

}
