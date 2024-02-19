using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Blazor.Shared.Services;
using Blazor.Shared.Models;



namespace BlazorAppDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost]
        public async Task<ActionResult<Users>> CreateUser(Users user)
        {
            var users = _userService.CreateUser(user);
            return Ok(users);
        }
    }
}
