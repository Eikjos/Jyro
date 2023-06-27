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

        public User? GetByEmail(string Email)
        {
            return _UserRepository.GetByEmail(Email);
        }

        public User? GetById(Guid Id)
        {
            return _UserRepository.GetById(Id);
        }

        public User Insert(User user)
        {
            return _UserRepository.Insert(user);
        }

        public void Delete(User user)
        {
            _UserRepository.Delete(user.Id);
        }
    }
}
