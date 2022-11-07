using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        public string textReport { get; set; }
        public User User { get; set; }
        public Station Station { get; set; }
    }
}
