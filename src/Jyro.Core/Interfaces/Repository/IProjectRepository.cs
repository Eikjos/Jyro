using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Interfaces.Repository
{
    public interface IProjectRepository : ICrudRepository<Project>
    {
        IQueryable<Project> GetAllByUserId(Guid userId);
    }
}
