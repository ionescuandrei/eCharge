using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eChargeAPI.Models
{
    public class ChargingPlug
    {
        public int Id { get; set; }
        public byte Status { get; set; }
        public string ConnectorType { get; set; }
        public float PriceKw { get; set; }
        public float ChargingSpeedKw { get; set; }
        public ChargingPoint ChargingPoint{ get; set; }

    }
}
