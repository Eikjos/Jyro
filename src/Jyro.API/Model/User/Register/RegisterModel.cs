using Jyro.API.Attribute;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jyro.API.Model.User.Register
{
    public class RegisterModel
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Password]
        public string Password { get; set; }
    }
}
