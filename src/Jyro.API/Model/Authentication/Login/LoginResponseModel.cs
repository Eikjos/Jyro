using Jyro.API.Model.Authentication.Auth;
using Jyro.Core.Enum;

namespace Jyro.API.Model.Authentication.Login
{
    public class LoginResponseModel
    {
        public UserModel User { get; set; }
        public string Token { get; set; }

        public LoginResponseModel(Jyro.Core.Entities.User user, string token) {
            User = new UserModel(user);
            Token = token;
        }
    }
}
