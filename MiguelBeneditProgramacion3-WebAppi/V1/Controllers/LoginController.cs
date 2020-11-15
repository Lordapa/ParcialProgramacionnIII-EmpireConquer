using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MiguelBeneditProgramacion3_Core.Entities;
using MiguelBeneditProgramacion3_Core.Enums;
using System.Text;

namespace MiguelBeneditProgramacion3_WebApplication.V1.Controllers
{
    /// <summary>
    /// Login api controller
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class LoginController:ControllerBase
    {
        private readonly IConfiguration _config;

        public LoginController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] User login)
        {
            IActionResult response = Unauthorized();

            var user = Authenticate(login);
            if (user != null)
            {
                string tokenString = GenerateToken(user);
                response = Ok(new { token = tokenString, userData = user });
            }

            return response;
        }

        private User Authenticate(User credentials)
        {
            //validate credential in database y encriptar credentias
            var credentialData = new User()
            {
                FirstName = "SuperAdmin",
                CreatedBy = "Miguel",
                CreatedDate = DateTime.Now,
                Email = "a@a.com",
                Id = 1,
                LastName = "SuperAdmin",
                Password = "12345",
                Role = RoleType.Admin
            };

            return credentialData;
        }

        private string GenerateToken(User credentialData)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,credentialData.UserName),
                new Claim("fullName",credentialData.Email),
                new Claim("role",credentialData.Role.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };
            
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims : claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials:credentials
            );
            
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
