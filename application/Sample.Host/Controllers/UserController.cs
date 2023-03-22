using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Application.Services;
using Sample.Host.ViewModels.Response;
using Sample.Infratructure;
using Sample.Infratructure.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserDto req)
        {
            var result = await _userService.Create(req);
            return Ok(new ResponseApi(result, true));
        }
    }
}
