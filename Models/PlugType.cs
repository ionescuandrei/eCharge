using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class PlugType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PlugTypeName { get; set; }
        public Car Car { get; set; }
    }
}
