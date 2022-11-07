using eChargeAPI.Models;
using eChargeAPI.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace eChargeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepo _carRepo;

        public CarController( ICarRepo carRepo)
        {
            _carRepo = carRepo ??
                throw new ArgumentNullException(nameof(carRepo)); ;
        }
        [HttpGet]
        [Route("GetCars")]
        public async Task<IActionResult> GetCars()
        {
            return Ok(await _carRepo.GetAllCars());
        }
  
        [HttpGet]
        [Route("GetCarById")]
        public async Task<IActionResult> GetCarById(int id)
            {
                return Ok(await _carRepo.GetCarById(id));
            }
        [HttpPost]
        [Route("AddCar")]
        public async Task<IActionResult> AddCar(Car car)
        {
            var result = await _carRepo.InsertCar(car);
            if (result.Id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
           return Ok("Added Successfully");
        }
        [HttpPut]
        [Route("UpdateCar")]
        public async Task<IActionResult> UpdateCar(Car car)
        {
            await _carRepo.UpdateCar(car);
            return Ok("Update Successfully");
        }
        [HttpDelete]
        [Route("DeleteCar")]

        public JsonResult Delete(int id)
        {
            _carRepo.DeleteCar(id);
            return new JsonResult("Deleted Successfully");
        }
    }
}
