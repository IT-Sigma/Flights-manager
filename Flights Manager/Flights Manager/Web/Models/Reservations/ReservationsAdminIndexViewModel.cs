using System.Collections;
using System.Collections.Generic;
using Web.Models.Shared;

namespace Web.Models.Reservations
{
    public class ReservationsAdminIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<ReservationsAdminViewModel> Items { get; set; }
    }
}
