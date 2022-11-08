using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.DTOs
{
    public class RegisterModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public string PhoneNumner { get; set; }
        [Required]
        public string Email { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
    }
}
