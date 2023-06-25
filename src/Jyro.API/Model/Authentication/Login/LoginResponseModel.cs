using Jyro.Core.Entities;
using Jyro.Core.Enum;

namespace Jyro.API.Model.Authentication.Login
{
    public class LoginResponseModel
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Token { get; set; }
        public RoleType Role { get; set; }

        public LoginResponseModel(User user, string token) {
            Id = user.Id;
            Firstname = user.Firstname;
            Lastname = user.Lastname;
            Role = user.Role;
            Token = token;
        }
    }
}
