using System.Collections.Generic;
using System;

namespace eChargeAPI.Utils.Structure
{
    public class RoutingFinalResponse
    {
       public double TotalTravelTime { get; set; }
        double TotalTravelDistance { get; set; }
        double TotalTravelPrice { get; set; }
        List<LegData> Legs { get; set; }

        public RoutingFinalResponse()
        {
            TotalTravelTime = 0.0;
            TotalTravelDistance = 0.0;
            TotalTravelPrice = 0.0;
            Legs = new List<LegData>();
        }

        public RoutingFinalResponse(double totalTravelTime, double totalTravelDistance, double totalTravelPrice, List<LegData> legs)
        {
            TotalTravelTime = totalTravelTime;
            TotalTravelDistance = totalTravelDistance;
            TotalTravelPrice = totalTravelPrice;
            Legs = legs;
        }       
    }
}
