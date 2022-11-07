namespace eChargeAPI.Models
{
    public class Station
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public User User { get; set; }

    }
}
