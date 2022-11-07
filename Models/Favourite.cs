namespace eChargeAPI.Models
{
    public class Favourite
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Station Station { get; set; }
    }
}
