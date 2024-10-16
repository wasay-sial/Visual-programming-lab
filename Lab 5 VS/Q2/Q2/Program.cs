using System;
using System.Collections.Generic;

public class Customer
{
    public int CustomerId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    
    public List<Reservation> Reservations { get; set; } = new List<Reservation>();
}

public class RetailCustomer : Customer
{
    public string CreditCardType { get; set; }
    public string CreditCardNo { get; set; }
}

public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; }
    public int FrequentFlyerPts { get; set; }
    public string BillingAccountNo { get; set; }
}

public class Reservation
{
    public int ReservationNo { get; set; }
    public DateTime Date { get; set; }

    public List<Seat> Seats { get; set; } = new List<Seat>();
}

public class Flight
{
    public int FlightId { get; set; }
    public DateTime Date { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public TimeSpan DepartureTime { get; set; }
    public TimeSpan ArrivalTime { get; set; }
    public int SeatingCapacity { get; set; }

    // List of seats available in the flight
    public List<Seat> Seats { get; set; } = new List<Seat>();
}

public class Seat
{
    public int RowNo { get; set; }
    public int SeatNo { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }
}


public class Program
{
    public static void Main(string[] args)
    {
        
        Flight flight1 = new Flight
        {
            FlightId = 101,
            Date = DateTime.Now,
            Origin = "New York",
            Destination = "Los Angeles",
            DepartureTime = new TimeSpan(10, 0, 0),
            ArrivalTime = new TimeSpan(13, 30, 0),
            SeatingCapacity = 150
        };

        
        Seat seat1 = new Seat { RowNo = 1, SeatNo = 1, Price = 150.00m, Status = "Available" };
        Seat seat2 = new Seat { RowNo = 1, SeatNo = 2, Price = 150.00m, Status = "Available" };
        flight1.Seats.Add(seat1);
        flight1.Seats.Add(seat2);

        
        RetailCustomer retailCustomer = new RetailCustomer
        {
            CustomerId = 1,
            FirstName = "John",
            LastName = "Doe",
            Street = "123 Main St",
            City = "New York",
            State = "NY",
            ZipCode = "10001",
            Phone = "123-456-7890",
            Email = "johndoe@example.com",
            Password = "password123",
            CreditCardType = "Visa",
            CreditCardNo = "4111111111111111"
        };

        
        CorporateCustomer corporateCustomer = new CorporateCustomer
        {
            CustomerId = 2,
            FirstName = "Jane",
            LastName = "Smith",
            Street = "456 Corporate Blvd",
            City = "Los Angeles",
            State = "CA",
            ZipCode = "90001",
            Phone = "987-654-3210",
            Email = "janesmith@corporate.com",
            Password = "securepass456",
            CompanyName = "TechCorp",
            FrequentFlyerPts = 5000,
            BillingAccountNo = "CORP123456"
        };

        
        Reservation reservation1 = new Reservation
        {
            ReservationNo = 1001,
            Date = DateTime.Now
        };
        reservation1.Seats.Add(seat1);  
        seat1.Status = "Reserved";     
        retailCustomer.Reservations.Add(reservation1);  

        
        Reservation reservation2 = new Reservation
        {
            ReservationNo = 1002,
            Date = DateTime.Now
        };
        reservation2.Seats.Add(seat2);  
        seat2.Status = "Reserved";     
        corporateCustomer.Reservations.Add(reservation2);  

        
        Console.WriteLine("Retail Customer Reservation:");
        PrintCustomerDetails(retailCustomer);
        Console.WriteLine("\nCorporate Customer Reservation:");
        PrintCustomerDetails(corporateCustomer);

        
        Console.WriteLine("\nFlight Details:");
        PrintFlightDetails(flight1);
    }

    
    public static void PrintCustomerDetails(Customer customer)
    {
        Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.FirstName} {customer.LastName}");
        foreach (var reservation in customer.Reservations)
        {
            Console.WriteLine($"  Reservation No: {reservation.ReservationNo}, Date: {reservation.Date}");
            foreach (var seat in reservation.Seats)
            {
                Console.WriteLine($"    Seat: Row {seat.RowNo}, Seat {seat.SeatNo}, Price: {seat.Price}, Status: {seat.Status}");
            }
        }
    }

    
    public static void PrintFlightDetails(Flight flight)
    {
        Console.WriteLine($"Flight ID: {flight.FlightId}, From {flight.Origin} to {flight.Destination}");
        Console.WriteLine($"Departure: {flight.DepartureTime}, Arrival: {flight.ArrivalTime}");
        Console.WriteLine("Seats:");
        foreach (var seat in flight.Seats)
        {
            Console.WriteLine($"  Row {seat.RowNo}, Seat {seat.SeatNo}, Price: {seat.Price}, Status: {seat.Status}");
        }
    }
}
