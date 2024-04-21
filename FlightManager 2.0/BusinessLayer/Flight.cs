using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }
        [Required]
        public string PlaneNumber { get; set; }
        [Required]
        public string LocationFrom { get; set; }
        [Required]
        public string LocationTo { get; set; }
        [Required]
        public DateTime TakeOff { get; set; }
        //validation
        [Required]
        public DateTime Landing { get; set; }
        [Required]
        public string PlaneType { get; set; }
        [Required]
        public string PilotName { get; set; }
        [Required]
        public int UnoccupiedSeats { get; set; }
        [Required]
        public int UnoccupiedBusinessSeats { get; set; }
        public TimeSpan Duration 
        { 
            get 
            {
                return new TimeSpan(Landing.Day - TakeOff.Day, Landing.Hour - TakeOff.Hour, Landing.Minute - TakeOff.Minute, Landing.Second - TakeOff.Second);
            } 
        }

        public Reservation Reservation { get; set; }

        public Flight()
        {
             
        }
        public Flight(int flightId)
        {
            FlightId = flightId;
        }

        public Flight(int flightId, string planeNumber, string locationFrom, string locationTo, DateTime takeOff, DateTime landing, string planeType, string pilotName, int unoccupiedSeats, int unoccupiedBusinessSeats, Reservation reservation)
        {
            FlightId = flightId;
            PlaneNumber = planeNumber;
            LocationFrom = locationFrom;
            LocationTo = locationTo;
            TakeOff = takeOff;
            Landing = landing;
            PlaneType = planeType;
            PilotName = pilotName;
            UnoccupiedSeats = unoccupiedSeats;
            UnoccupiedBusinessSeats = unoccupiedBusinessSeats;
            Reservation = reservation;
        }
    }
}