using System.Collections.Generic;

namespace eChargeAPI.Utils.Structure
{
    public class LegData
    {
        public long StationId { get; set; }
        public double PriceKw { get; set; }
        public double CurrentChargeInkWhAfterRecharge { get; set; }
        public List<Coords> Points { get; set; }
        public string Address { get; set; }

        public LegData(long stationId, double priceKw, double currentChargeInkWhAfterRecharge, List<Coords> points, string address)
        {
            StationId = stationId;
            PriceKw = priceKw;
            CurrentChargeInkWhAfterRecharge = currentChargeInkWhAfterRecharge;
            Points = points;
            Address = address;
        }
    }
}
