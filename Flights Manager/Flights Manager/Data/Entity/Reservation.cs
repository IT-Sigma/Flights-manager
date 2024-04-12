using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Data.Enumeration;


namespace Data.Entity
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        //da se machnat
        [AllowNull]
        public int UserId { get; set; }
        [AllowNull]
        public string PlaneNumber { get; set; }
        public int FlightId { get; set; }
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
