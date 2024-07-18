using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NicCRUDAPI.BAL.IServices;
using NicCRUDAPI.Models;

namespace NicCRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService=userService;
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateUser(UserModel req)
        {
            _userService.CreateUserAsync(req);
            return Ok();
        }


    }
}
