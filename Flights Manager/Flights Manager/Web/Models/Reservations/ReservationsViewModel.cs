using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using Data.Enumeration;
using Microsoft.AspNetCore.Mvc;
using Web.Attributes;
using Web.Models.Flights;

namespace Web.Models.Reservations
{
    public class ReservationsViewModel
    {
        public int ReservationId { get; set; }
        public int FlightId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int EGN { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public TicketTypeEnum TicketType { get; set; }
    }
}
