using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eChargeAPI.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]        
        public string Model { get; set; }
        [Required]
        public long Year { get; set; }
        [Required]
        public double BatteryCapacity { get; set; }
        public double ChargingCapacity { get; set; }
        [Required]
        public int VehicleMaxSpeed { get; set; }
        [Required]
        public float Auxiliary_kwh { get; set; }
        public User Owner_id { get; set; }


    }
}
