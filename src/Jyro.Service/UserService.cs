using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Repository.Base;
using Jyro.Core.Interfaces.Service;
using Jyro.Infra.Repository.Base;
using Jyro.Service.Base;

namespace Jyro.Service
{
    public class UserService : CrudService<IUserRepository, User>, IUserService
    {

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
        }

        public User? GetByEmail(string Email)
        {
            return this.GetRepository().GetByEmail(Email);
        }
    }
}
