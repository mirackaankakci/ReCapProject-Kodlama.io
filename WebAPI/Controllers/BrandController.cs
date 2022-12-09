using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.getAllBrand();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id) {
            var result = _brandService.GetBrand(id);
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addbrand")]
        public IActionResult addBrand(Brand brand) {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }

        [HttpDelete]
        public IActionResult deleteBrand(Brand brand) {
            var result = _brandService.Remove(brand);
            if (result.Success) {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("updatebrand")]
        public IActionResult updateBrand(Brand brand) {
            var result = _brandService.Update(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
            
        }
    }
}
