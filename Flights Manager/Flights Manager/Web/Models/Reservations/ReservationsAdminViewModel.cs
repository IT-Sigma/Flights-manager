using System.ComponentModel.DataAnnotations;
using System;
using Data.Enumeration;

namespace Web.Models.Reservations
{
    public class ReservationsAdminViewModel
    {
        public int ReservationId { get; set; }
        public int PlaneNumber { get; set; }
        public int UserId { get; set; }
    }
}