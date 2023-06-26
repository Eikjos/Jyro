using AutoMapper.Features;
using Jyro.API.Controllers.Base;
using Jyro.API.Model.User.Register;
using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace Jyro.API.Controllers
{
    public class UsersController : BaseAPIController
    {
        private readonly IUserService _UserService;

        public UsersController(IUserService userService)
        {
            _UserService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            if (_UserService.GetByEmail(model.Email) != null)
                return BadRequest("email.already.exist");

            var mapper = Jyro.API.Helper.AutoMapper.GetMapper<RegisterModel, User>();

            var user = mapper.Map<User>(model);
            user.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);

            user = _UserService.Insert(user);

            return Ok();
        }
    }
}
