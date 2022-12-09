using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : Controller
    {
        IRentalService _rentalService;

        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result= _rentalService.restalList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }



        [HttpGet("getbyid")]
        public IActionResult getById(int id) {
            var result=_rentalService.listByRentalId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addRental")]
        public IActionResult addRental(Rental rental) {
            var result = _rentalService.add(rental);
            if (result.Success) { 
            return Ok(result);
            }
            return BadRequest(result);
        
        }

        [HttpDelete("deleterental")]
        public IActionResult deleteResult(Rental rental)
        {
            var result = _rentalService.delet(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updareresult")]
        public IActionResult updateResult(Rental rental) {
            var result = _rentalService.update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deliverresult")]
        public IActionResult deliverResult(Rental rental) {
            var result = _rentalService.deliver(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        
        }
    }
}
