using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using Web.Attributes;

namespace Web.Models.Flights
{
    public class FlightsEditViewModel
    {
        [Required]
        public int PlaneNumber { get; set; }
        [Required]
        public string LocationFrom { get; set; }
        [Required]
        public string LocationTo { get; set; }
        [Required]
        public DateTime TakeOff { get; set; }
        [Required]
        [FlightsDates]
        public DateTime Landing { get; set; }
        [Required]
        public string PlaneType { get; set; }
        [Required]
        public string PilotName { get; set; }
        [Required]
        public int UnoccupiedSeats { get; set; }
        [Required]
        public int UnoccupiedBusinessSeats { get; set; }
    }
}
