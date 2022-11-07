using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eChargeAPI.Models
{
    public class ChargingPlug
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public byte Status { get; set; }
        [Required]
        public string ConnectorType { get; set; }                
        public float PriceKw { get; set; }
        [Required]
        public float ChargingSpeedKw { get; set; }
        public ChargingPoint ChargingPoint{ get; set; }

    }
}
