using eChargeAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eChargeAPI.Repos
{
    public interface ICarRepo
    {
       Task<IEnumerable<Car>> GetAllCars();
        Task<IEnumerable<Car>> GetCarByUserId(int userId);
        Task<Car> GetCarById(int carId);
        Task<Car> InsertCar(Car car);
        Task<Car> UpdateCar(Car car);
        bool DeleteCar(int r);     
                
    }
}
