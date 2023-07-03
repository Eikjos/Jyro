using Jyro.Core.Enum;

namespace Jyro.API.Model.Authentication.Auth
{
    public class AuthResponseModel
    {
        public UserModel User { get; set; }
        public string Token { get; set; }

        public AuthResponseModel(Jyro.Core.Entities.User user, string token)
        {
            Token = token;
            User = new UserModel(user);
        }
    }

    public class UserModel {

        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public RoleType Role { get; set; }

        public UserModel(Jyro.Core.Entities.User user)
        {
            Id = user.Id;
            Firstname = user.FirstName;
            Lastname = user.LastName;
            Role = user.Role;
        }
    }

}
