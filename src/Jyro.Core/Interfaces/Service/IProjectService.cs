using Jyro.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Interfaces.Service
{
    public interface IProjectService
    {
        Project Create(Project project);
        IEnumerable<Project> GetAllByUserId(Guid userId);
    }
}
