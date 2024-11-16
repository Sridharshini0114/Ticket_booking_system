

namespace Ticket_Booking_System.Repository
{
    internal interface IEvent
    {
        decimal CalculateTotalRevenue();
        int GetBookedNoOfTickets();
        bool BookTickets(int numTickets);
        bool CancelBooking(int numTickets);
        void DisplayEventDetails();

    }
}
