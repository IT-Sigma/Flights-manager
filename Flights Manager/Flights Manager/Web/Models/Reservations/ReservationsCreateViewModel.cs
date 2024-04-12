using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Data.Enumeration;
using Web.Attributes;

namespace Web.Models.Reservations
{
    public class ReservationsCreateViewModel
    {
        [Key]
        [Required]
        public int ReservationId { get; set; }
        [AllowNull] 
        public int FlightId { get; set; }
        [AllowNull]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int EGN { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public TicketTypeEnum TicketType { get; set; }
    }
}
