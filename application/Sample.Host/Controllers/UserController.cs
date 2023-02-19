using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Core;
using Sample.Core.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userService;

        public UserController(IUserServices userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserDto req)
        {
            try
            {
                var result = await _userService.Create(req);
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
