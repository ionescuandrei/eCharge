namespace eChargeAPI.Models
{
    public class PayPalDetail
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string clientId { get; set; }
        public string secret { get; set; }
    }
}
