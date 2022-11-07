using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        public string Description { get; set; }
        public User User { get; set; }

    }
}
