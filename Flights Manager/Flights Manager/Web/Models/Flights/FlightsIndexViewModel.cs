using System.Collections.Generic;
using Web.Models.Flights;
using Web.Models.Reservations;
using Web.Models.Shared;

namespace Web.Models.Flights
{
    public class FlightsIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<FlightsViewModel> Items { get; set; }
    }
}
