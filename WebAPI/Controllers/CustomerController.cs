using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        ICustomerService _customerservice;

        public CustomerController(ICustomerService customerservice)
        {
            _customerservice = customerservice;
        }

        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result = _customerservice.getAllCustomer();
            if (result.Success) {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult getById(int id) {

            var result = _customerservice.GetCustomer(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }

        [HttpPost("addcustomer")]
        public IActionResult addCustomer(Customer customer) {
            var resutl=_customerservice.Add(customer);
            if (resutl.Success)
            {
                return Ok(resutl);
            }
            return BadRequest(resutl);
        }

        [HttpPost("deletecustomer")]
        public IActionResult deleteCustomer(Customer customer) {
            var result = _customerservice.Remove(customer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("updatecustomer")]
        public IActionResult updateCustomer(Customer customer)
        {
            var result = _customerservice.Update(customer);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
