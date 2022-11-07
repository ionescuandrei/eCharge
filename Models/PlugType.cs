using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class PlugType
    {
        [Key]
        public int Id { get; set; }
        public string PlugTypeName { get; set; }
        public Car Car { get; set; }
    }
}
