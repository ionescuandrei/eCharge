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
        public string Model { get; set; }
        public long Year { get; set; }
        public double BatteryCapacity { get; set; }
        public int VehicleMaxSpeed { get; set; }
        public float Auxiliary_kwh { get; set; }
        public User Owner_id { get; set; }


    }
}
