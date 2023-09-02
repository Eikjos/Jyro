using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Repository.Base;
using Jyro.Core.Interfaces.Service;
using Jyro.Infra.Repository.Base;
using Jyro.Service.Base;

namespace Jyro.Service
{
    public class UserService : BaseService<User>, IUserService
    {

        public UserService(BaseRepository<User> userRepository) : base(userRepository)
        {
        }

        public User? GetByEmail(string Email)
        {
            return this.GetRepository().GetByEmail(Email);
        }

        protected override IUserRepository GetRepository()
        {
            return (IUserRepository)base.GetRepository();
        }
    }
}
