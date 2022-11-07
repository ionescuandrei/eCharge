using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class PayPalDetail
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        [Required]
        public string clientId { get; set; }
        [Required]
        public string secret { get; set; }
    }
}
