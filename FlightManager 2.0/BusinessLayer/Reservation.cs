using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BusinessLayer
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        //da se machnat
        //[AllowNull]
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        //[AllowNull]
        public Flight Flight { get; set; }
        [Required]
        public string PlaneNumber { get; set; }
        public int FlightId { get; set; }
        [Required]
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
        public TicketTypeEnum TicketType { get; set; }

        public Reservation()
        {
                
        }
        public Reservation(int reservationId)
        {
            ReservationId = reservationId;
        }
        public Reservation(int reservationId, int userId, string planeNumber, int flightId, string firstName, string surname, string lastName, string email, int eGN, string address, int phoneNumber, string nationality, TicketTypeEnum ticketType)
        {
            ReservationId = reservationId;
            UserId = userId;
            PlaneNumber = planeNumber;
            FlightId = flightId;
            FirstName = firstName;
            Surname = surname;
            LastName = lastName;
            Email = email;
            EGN = eGN;
            Address = address;
            PhoneNumber = phoneNumber;
            Nationality = nationality;
            TicketType = ticketType;
        }
    }
}