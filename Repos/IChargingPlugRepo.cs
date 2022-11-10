using eChargeAPI.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace eChargeAPI.Repos
{
    public interface IChargingPlugRepo
    {
     Task<IEnumerable<ChargingPlug>> FindAll();

     Task<IEnumerable<ChargingPlug>> FindChargingPlugsByChargingPoint(ChargingPoint chargingPoint);     

     Task<IEnumerable<ChargingPlug>> FindChargingPlugsByConnectorType(String connectorType);

     Task<ChargingPlug> FindChargingPlugById(int id);

     Task<IEnumerable<ChargingPlug>> FindChargingPlugsByChargingPointId(int chargingPoint_id);
     bool deleteById(int id);
    }
}
