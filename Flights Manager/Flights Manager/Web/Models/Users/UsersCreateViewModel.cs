using Microsoft.AspNetCore.Builder;
using System;
using System.ComponentModel.DataAnnotations;
using Web.Attributes;
using Data.Enumeration;

namespace Web.Models.Users
{
    public class UsersCreateViewModel
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email{ get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int EGN{ get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PhoneNumber {  get; set; }
        [Required]
        public RoleEnum Role { get; set; }
    }
}
