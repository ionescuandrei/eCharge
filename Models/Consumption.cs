using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class Consumption
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Speed { get; set; }
        [Required]
        public float Consumption_kwh { get; set; }
       
        public Car Car_id { get; set; }
    }
}
