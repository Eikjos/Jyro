using AutoMapper;
using Jyro.API.Profiles;
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
            #region Service configuration
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ISprintRepository, SprintRepository>();
            services.AddScoped<ISprintService, SprintService>();
            #endregion

            #region Automapper configuration (Profile)
            services.AddAutoMapper(typeof(SprintProfile), typeof(ProjectProfile), typeof(UserProfile));
            #endregion
        }
    }
}
