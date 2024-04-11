using System.Collections;
using System.Collections.Generic;
using Web.Models.Shared;
using Data.Entity;

namespace Web.Models.Reservations
{
    public class ReservationsAdminIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<Reservation> Items { get; set; }
    }
}
