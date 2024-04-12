using System.Collections;
using System.Collections.Generic;
using Web.Models.Shared;
using Web.Models.Flights;

namespace Web.Models.Reservations
{
    public class ReservationsIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<ReservationsViewModel> Items { get; set; }
    }
}
