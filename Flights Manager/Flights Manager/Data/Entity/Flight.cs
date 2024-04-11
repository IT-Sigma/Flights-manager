using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace Data.Entity
{
    public class Flight
    {
        [Key]
        public int PlaneNumber { get; set; }
        public string LocationFrom { get; set; }
        public string LocationTo { get; set; }
        public DateTime TakeOff { get; set; }
        //validation
        public DateTime Landing { get; set; }
        public string PlaneType { get; set; }
        public string PilotName { get; set; }
        public int UnoccupiedSeats { get; set; }
        public int UnoccupiedBusinessSeats { get; set; }
    }
}
