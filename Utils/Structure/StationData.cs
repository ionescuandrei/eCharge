using eChargeAPI.Models;

namespace eChargeAPI.Utils.Structure
{
    public class StationData
    {
        public Station Station { get; set; }
        public ChargingPlug ChargingPlug { get; set; }
        public StationData(Station station, ChargingPlug chargingPlug)
        {
            Station = station;
            ChargingPlug = chargingPlug;
        }
    }
}
