using Jyro.Core.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Jyro.API.Helper
{
    public class JWTHelper
    {
        public static string GenerateToken(User user, IConfiguration configuration)
        {
            // generate token that is valid for 7 days
            var key = configuration["Jwt:Secret"];
            var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var signInCredentials = new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256);
            var claims = new Claim[] {
                new Claim("id" ,user.Id.ToString()),
                new Claim("role", user.Role.ToString())
            };
            var dateExpire = DateTime.Now.AddDays(7);
            var jwt = new JwtSecurityToken(claims: claims, signingCredentials: signInCredentials, expires: dateExpire, audience: configuration["Jwt:Audience"], issuer: configuration["Jwt:Issuer"]);
            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
