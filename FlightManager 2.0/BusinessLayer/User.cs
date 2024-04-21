using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int EGN { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public RoleEnum Role { get; set; }

        public Reservation Reservation { get; set; }

        public User()
        {
                
        }
        public User(int id)
        {
            Id = id;
        }
        public User(int id, string username, string password, string email, string firstName, string lastName, int eGN, string address, int phoneNumber, RoleEnum role)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            EGN = eGN;
            Address = address;
            PhoneNumber = phoneNumber;
            Role = role;
        }
    }
}