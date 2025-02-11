using JwtAuthDotNet9.Entities;
using JwtAuthDotNet9.Models;
using JwtAuthDotNet9.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtAuthDotNet9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService service) : ControllerBase
    {
        public static User user = new User();
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            var result = await service.RegisterAsync(request);
            if(result is not null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            var result = await service.LoginAsync(request);
            if (result is not null)
            {
                return Ok(result);
            }
            
            return BadRequest();

        }
        

    }
}
