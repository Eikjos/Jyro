using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Interfaces.Service
{
    public interface IProjectService : ICrudService<IProjectRepository, Project>
    {
        IEnumerable<Project> GetAllByUserId(Guid userId);
    }
}
