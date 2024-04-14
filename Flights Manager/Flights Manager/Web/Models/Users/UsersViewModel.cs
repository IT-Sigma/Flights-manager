
using Microsoft.AspNetCore.Builder;
using System;
using System.ComponentModel.DataAnnotations;
using Web.Attributes;
using Data.Enumeration;

namespace Web.Models.Users
{
    public class UsersViewModel
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EGN{ get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public RoleEnum Role { get; set; }
    }
}
