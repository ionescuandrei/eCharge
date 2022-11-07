using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eChargeAPI.Models
{
    public class ChargingPoint
    {
        [Key]
        public int Id { get; set; }
        public Station Station { get; set; }
    }
}
