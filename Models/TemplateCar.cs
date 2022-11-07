using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class TemplateCar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public double BatteryCapacity { get; set; }
        [Required]
        public double ChargingCapacity { get; set; }
        [Required]
        public float VehicleMaxSpeed { get; set; }
        [Required]
        public double AuxialiaryKwh { get; set; }

    }
}
