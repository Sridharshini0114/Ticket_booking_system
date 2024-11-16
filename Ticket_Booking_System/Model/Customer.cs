

using Ticket_Booking_System.Repository;

namespace Ticket_Booking_System.Model
{
    internal class Customer:Icustomer
    {
        // Attributes
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Default constructor
        public Customer()
        {
            
        }

        // Parameterized constructor
        public Customer(string customerName, string email, string phoneNumber)
        {
            CustomerName = customerName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        // Method to display customer details
        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
    }
}
