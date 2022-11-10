using eChargeAPI.Models;
using eChargeAPI.Repos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eChargeAPI.Services
{
    public class SqlChargingPlugRepo : IChargingPlugRepo
    {
        public bool deleteById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ChargingPlug>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ChargingPlug> FindChargingPlugById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ChargingPlug>> FindChargingPlugsByChargingPoint(ChargingPoint chargingPoint)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ChargingPlug>> FindChargingPlugsByChargingPointId(int chargingPoint_id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ChargingPlug>> FindChargingPlugsByConnectorType(string connectorType)
        {
            throw new System.NotImplementedException();
        }
    }
}
