using Jyro.API.Constants;
using Jyro.Core.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Jyro.API.Attribute
{
    public class AuthorizeRoleAttribute : System.Attribute, IAuthorizationFilter
    {
        public RoleType[] Roles { get; set; }

        public AuthorizeRoleAttribute(RoleType[] roles)
        {
            Roles = roles;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context != null)
            {
                var role = (RoleType) context.HttpContext.Items[AppConstant.ROLE_TOKEN];

                if (!Roles.Any(r => r == role))
                    context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
            }
        }
    }
}
