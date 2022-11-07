using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class Favourite
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public Station Station { get; set; }
    }
}
