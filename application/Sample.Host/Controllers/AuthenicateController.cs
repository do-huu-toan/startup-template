using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Sample.Core.Dtos;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenicateController : ControllerBase
    {
		private readonly IConfiguration _configuration;

        public AuthenicateController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
		public async Task<IActionResult> GetToken()
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new Claim[]
				{
					new Claim(ClaimTypes.Name, "admin")
				}),
				Expires = DateTime.UtcNow.AddMinutes(10),
				SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);
			return Ok(new TokenDto { Token = tokenHandler.WriteToken(token) });
		}
		
	}
}
