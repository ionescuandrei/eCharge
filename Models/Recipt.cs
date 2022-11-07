using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class Recipt
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string Destinatar { get; set; }
        [Required]
        public string Expeditor { get; set; }
        public string Status { get; set; }
        public string Total { get; set; }       

    }
}
