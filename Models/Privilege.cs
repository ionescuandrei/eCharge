using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eChargeAPI.Models
{
    public class Privilege
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
