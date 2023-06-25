using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Infra.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Infra.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext AppDbContext) : base(AppDbContext)
        {
        }
    }
}
