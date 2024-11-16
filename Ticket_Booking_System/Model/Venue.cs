using System;
using System.Collections.Generic;

using Ticket_Booking_System.Repository;

namespace Ticket_Booking_System.Model
{
    internal class Venue:Ivenue
    {
        // Attributes
        public string VenueName { get; set; }
        public string Address { get; set; }

        // Default constructor
        public Venue()
        {
           
        }

        // Parameterized constructor
        public Venue(string venueName, string address)
        {
            VenueName = venueName;
            Address = address;
        }

        // Method to display venue details
        public void DisplayVenueDetails()
        {
            Console.WriteLine($"Venue Name: {VenueName}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}
