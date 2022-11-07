using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eChargeAPI.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> users { get; set; }

    }
}
