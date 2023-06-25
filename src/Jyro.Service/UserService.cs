using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Service;

namespace Jyro.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;

        public UserService(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }
         
        public User? GetById(Guid Id)
        {
            return _UserRepository.GetById(Id);
        }
    }
}
