using System.Collections.Generic;
using System;

namespace eChargeAPI.Utils.Structure
{
    public class RoutingRequestData
    {
        public List<Coords> LocationsCoords { get; set; }
        public string Avoid { get; set; }
        public CarData CarData { get; set; }

        public RoutingRequestData(List<Coords> locationsCoords, string avoid, CarData carData)
        {
            LocationsCoords = locationsCoords;
            Avoid = avoid;
            CarData = carData;
        }
    }
}
