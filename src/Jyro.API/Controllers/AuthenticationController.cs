using Jyro.API.Controllers.Base;
using Jyro.API.Helper;
using Jyro.API.Model.Authentication.Auth;
using Jyro.API.Model.Authentication.Login;
using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata.Ecma335;

namespace Jyro.API.Controllers
{
    [ApiController]
    public class AuthenticationController : BaseAPIController
    {
        private readonly IUserService _UserService;
        private readonly IConfiguration _Configuration;

        public AuthenticationController(IUserService userService, IConfiguration configuration)
        {
            _UserService = userService;
            _Configuration = configuration;
        }

        [Authorize]
        [HttpGet("auth")]
        public IActionResult Auth()
        {
            // refresh du token
            var userId = (Guid) HttpContext.Items["UserId"];
            var user  = _UserService.GetById(userId);
            var cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(7);
            cookieOptions.Path = "/";
            var token = JWTHelper.GenerateToken(user, _Configuration);

            Response.Cookies.Append("token", token, cookieOptions);

            return Ok(new AuthResponseModel(user, token));
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = _UserService.GetByEmail(model.Email);
            if (user == null)
                return BadRequest("email.not.found");

            if (!BCrypt.Net.BCrypt.Verify(model.Password, user.Password))
                return BadRequest("password.not.match");

            var cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(7);
            cookieOptions.Path = "/";
            var token = JWTHelper.GenerateToken(user, _Configuration);

            Response.Cookies.Append("token", token, cookieOptions);

            return Ok(new LoginResponseModel(user, token));
        }

        [Authorize]
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            // suppression du cookie d'authentification
            var cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now;
            cookieOptions.Path = "/";

            Response.Cookies.Append("token", "", cookieOptions);

            return Ok();
        }
    }
}
