namespace eChargeAPI.Models
{
    public class Order
    {
        public double TotalKw { get; set; }
        public static string Currency { get; set; } = "EUR";
        public static string Method { get; set; } = "paypal";
        public static string Intent { get; set; } = "sale";
        public string Description { get; set; }

    }
}
