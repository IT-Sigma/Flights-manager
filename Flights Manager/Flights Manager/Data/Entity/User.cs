﻿using Data.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public int EGN { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public RoleEnum Role{ get; set; }
    }
}
