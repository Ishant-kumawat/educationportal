using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol.Plugins;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using KaniniAcademy.Models;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly KaniniAcademyContext _context;

        public TokenController(IConfiguration config, KaniniAcademyContext context)
        {
            _configuration = config;
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Post(UserDetail _userData)
        {
            if (_userData != null && !string.IsNullOrEmpty(_userData.UserName) && !string.IsNullOrEmpty(_userData.Password))
            {
                var administrator = await GetAdministrator(_userData.UserName, _userData.Password);

                if (administrator != null)
                {
                    return GenerateTokenForUser(administrator, "Admin");
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }

            }
            else
            {
                return BadRequest("Invalid credentials");
            }

        }
        private async Task<UserDetail> GetAdministrator(string username, string password)
        {

            return await _context.UserDetails.FirstOrDefaultAsync(a => a.UserName == username && a.Password == password);
        }
        private IActionResult GenerateTokenForUser(object user, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),

            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: signIn);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token), user });
        }
    }
}
