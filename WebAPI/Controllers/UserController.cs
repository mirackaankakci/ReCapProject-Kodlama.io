using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserController : Controller
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("getall")]
        public IActionResult getAll()
        {
            var result = _userService.getAllUser();
            if(result.Success) {

                return Ok(result);
            
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult getById(int id) {

            var result = _userService.GetUser(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("adduser")]
        public IActionResult addUser(User user) {
            var result = _userService.Add(user);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleteduser")]
        public IActionResult deleteUser(User user) 
        {
            var result = _userService.Remove(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateuser")]
        public IActionResult updateUser(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }   
}
