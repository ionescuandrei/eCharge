using eChargeAPI.Data;
using eChargeAPI.Models;
using eChargeAPI.Repos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eChargeAPI.Services
{
    public class SqlCarRepo : ICarRepo 
    {
        private readonly eChargeContext _context;

        public SqlCarRepo(eChargeContext context)
        {
            _context = context;
        }

        public bool DeleteCar(int r)
        {
            var car = _context.Cars.FindAsync(r);
            bool result;
            if (car != null)
            {
                _context.Entry(car).State = EntityState.Deleted;
                _context.SaveChanges();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public async Task<IEnumerable<Car>> GetAllCars()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<Car> GetCarById(int carId)
        {
            return await _context.Cars.FindAsync(carId);
        }

        public async Task<IEnumerable<Car>> GetCarByUserId(int userId)
        {
            var user_cars = await _context.Cars.Where(c => c.Owner_id.Id == userId).ToListAsync();
            return user_cars;
        }

        public async Task<Car> InsertCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return car;
        }

        public async Task<Car> UpdateCar(Car car)
        {
            _context.Entry(car).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return car;
        }
    }
}
