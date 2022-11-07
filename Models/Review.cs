using System.ComponentModel.DataAnnotations;

namespace eChargeAPI.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string TextReview { get; set; }
        public byte Rating { get; set; }
        public User User { get; set; }
        public Station Station { get; set; }

    }
}
