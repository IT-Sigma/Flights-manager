using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Data.Enumeration;


namespace Data.Entity
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public int PlaneNumber { get; set; }
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
