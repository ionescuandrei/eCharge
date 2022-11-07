using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class TemplateCar
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double BatteryCapacity { get; set; }
        public double ChargingCapacity { get; set; }
        public float VehicleMaxSpeed { get; set; }
        public double AuxialiaryKwh { get; set; }

    }
}
