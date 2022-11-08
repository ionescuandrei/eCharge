using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eChargeAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }       
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumner { get; set; }
        [Required]
        public string Email { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public bool IsEnable { get; set; }
        public string PasswordResetToken { get; set; }

    }
}
