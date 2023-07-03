using Jyro.API.Model.Authentication.Auth;
using Jyro.Core.Enum;

namespace Jyro.API.Model.Authentication.Login
{
    public class LoginResponseModel
    {
        public UserModel User { get; set; }
        public string Token { get; set; }

        public LoginResponseModel(Jyro.Core.Entities.User user, string token) {
            User = new UserModel
            {
                Id = user.Id,
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Role = user.Role,
            };
            Token = token;
        }
    }
}
