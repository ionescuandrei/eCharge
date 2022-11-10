using eChargeAPI.Models;
using System.Collections.Generic;
using System;
using eChargeAPI.Data;

namespace eChargeAPI.Utils.Structure
{
    public class RouteData
    {
        private readonly RoutingRequestData _routingRequestData;
        public List<Coords> LocationsCoords { get; set; }
        public string Avoid { get; set; }
        public Car Car { get; set; }
        public double CurrentChargeInkWh { get; set; }
        public List<Consumption> ConstantSpeedConsumptionInkWhPerHundredkm { get; set; }
        public RouteData(List<Coords> coords, string avoid,Car car, double current, List<Consumption> speedconsum)
        {
            LocationsCoords =coords;
            Avoid =avoid;
            Car=car;
            CurrentChargeInkWh=current;
            ConstantSpeedConsumptionInkWhPerHundredkm=speedconsum;
        }       

      

        public RouteData(RoutingRequestData routingRequestData)
        {
            _routingRequestData = routingRequestData;
            LocationsCoords = _routingRequestData.LocationsCoords;
            Avoid = routingRequestData.Avoid;
        }   

     
    }
}
