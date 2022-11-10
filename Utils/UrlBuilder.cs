using eChargeAPI.Models;
using eChargeAPI.Utils.Structure;
using System;
using System.Security.Policy;
using System.Text;

namespace eChargeAPI.Utils
{
    public class UrlBuilder
    {
        private static string tomTomApiKey = "WJ8s7PREG7SxRMtQTZaS6c0kyLjO5lfa";
        private static string baseURL = "https://api.tomtom.com";
        private static string routeType = "shortest";
        private static string vehicleEngineType = "electric";

        public static Uri GeneraterouteURL(RouteData routeData)
        {
            StringBuilder stringBuilder = new StringBuilder(baseURL);
            stringBuilder.Append("/routing/1/calculateRoute/");

            // Add locations.
            int i;
            for (i = 0; i < routeData.LocationsCoords.Count - 1; i++)
            {
                stringBuilder.Append(routeData.LocationsCoords[i].lat);
                stringBuilder.Append("%2C");
                stringBuilder.Append(routeData.LocationsCoords[i].lon);
                stringBuilder.Append("%3A");
            }

            // Add the last location.
            stringBuilder.Append(routeData.LocationsCoords[i].lat);
            stringBuilder.Append("%2C");
            stringBuilder.Append(routeData.LocationsCoords[i].lon);

            // Content-Type.
            stringBuilder.Append("/json?");

            // Add routeType.
            stringBuilder.Append("routeType=");
            stringBuilder.Append(routeType);
            stringBuilder.Append("&");

            // Add avoid.
            if (routeData.Avoid != null)
            {
                stringBuilder.Append("avoid=");
                stringBuilder.Append(routeData.Avoid);
                stringBuilder.Append("&");
            }

            // Add travelMode.
            stringBuilder.Append("travelMode=");
            stringBuilder.Append("car");
            stringBuilder.Append("&");

            // Add car details.
            Car car = routeData.Car;
            if (car != null)
            {
                // Add vehicle max speed.
                stringBuilder.Append("vehicleMaxSpeed=");
                stringBuilder.Append(car.VehicleMaxSpeed);
                stringBuilder.Append("&");

                // Add engine type. Electric by default.
                stringBuilder.Append("vehicleEngineType=");
                stringBuilder.Append(vehicleEngineType);
                stringBuilder.Append("&");

                // Add constantSpeedConsumptionInkWhPerHundredkm.
                stringBuilder.Append("constantSpeedConsumptionInkWhPerHundredkm=");
                for (i = 0; i < routeData.ConstantSpeedConsumptionInkWhPerHundredkm.Count - 1; i++)
                {
                    stringBuilder.Append(routeData.ConstantSpeedConsumptionInkWhPerHundredkm[i].Speed);
                    stringBuilder.Append("%2C");
                    stringBuilder.Append(routeData.ConstantSpeedConsumptionInkWhPerHundredkm[i].Consumption_kwh);
                    stringBuilder.Append("%3A");
                }

                // Add the last constSpeed...
                stringBuilder.Append(routeData.ConstantSpeedConsumptionInkWhPerHundredkm[i].Speed);
                stringBuilder.Append("%2C");
                stringBuilder.Append(routeData.ConstantSpeedConsumptionInkWhPerHundredkm[i].Consumption_kwh);
                stringBuilder.Append("&");

                // Add current Charge.
                stringBuilder.Append("currentChargeInkWh=");
                stringBuilder.Append(routeData.CurrentChargeInkWh);
                stringBuilder.Append("&");

                // Add max charge Charge.
                stringBuilder.Append("maxChargeInkWh=");
                stringBuilder.Append(car.BatteryCapacity);
                stringBuilder.Append("&");

                // Add auxiliary Ink.
                stringBuilder.Append("auxiliaryPowerInkW=");
                stringBuilder.Append(car.Auxiliary_kwh);
                stringBuilder.Append("&");
            }

            stringBuilder.Append("key=");
            stringBuilder.Append(tomTomApiKey);

            return new Uri(stringBuilder.ToString());
        }

    }
}