using Common.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Repositories;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;

namespace ProjectManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private UsersRepository repo = new UsersRepository();
        
        [HttpPut]
        public IActionResult Put(string username, string password)
        {
            User loggedUser = repo.GetFirstOrDefault(u => u.Username == username &&
                                                          u.Password == password);
            if(loggedUser == null)
            {
                return Unauthorized();
            }

            var claims = new[]
            {
                new Claim("LoggedUserId",loggedUser.Id.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1597532486!pass1597532486!pass"));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                "ulpia.tech",
                "projectmanagement.angular.app",
                claims,
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: signingCredentials
                );

            string jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(new { success = true, token = jwt });
        }
    }
}
