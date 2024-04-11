﻿using System.Collections.Generic;
using Web.Models.Flights;
using Web.Models.Shared;

namespace Web.Models.Users
{
    public class UsersIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<UsersViewModel> Items { get; set; }
    }
}
