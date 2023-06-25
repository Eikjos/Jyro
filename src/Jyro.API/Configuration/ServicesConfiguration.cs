using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Service;
using Jyro.Infra.Repository;
using Jyro.Service;

namespace Jyro.API.Configuration
{
    public class ServicesConfiguration
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
