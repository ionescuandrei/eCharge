using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double TotalKw { get; set; }
        [Required]
        public static string Currency { get; set; } = "EUR";
        public static string Method { get; set; } = "paypal";
        public static string Intent { get; set; } = "sale";
        public string Description { get; set; }

    }
}
