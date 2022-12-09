using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//ATTI
    public class CarsController : Controller
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result =_carService.getAll();
            if (result.Success) {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id) {

            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        
        }

        [HttpPost("addcars")]
        public IActionResult addCar(Car car) {
           var result=_carService.Add(car);
            if (result.Success)
            {

                return Ok(result);
            }
            return BadRequest(result.Message);
        
        }

        [HttpDelete("deletedcar")]
        public IActionResult deleteCar(Car car) {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }

        [HttpPost("updatecar")]
        public IActionResult updateCar(Car car){
            
          var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
