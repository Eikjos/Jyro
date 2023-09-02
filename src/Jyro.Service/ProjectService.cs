using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Service;
using Jyro.Infra.Repository.Base;
using Jyro.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Service
{
    public class ProjectService : BaseService<Project>, IProjectService
    {
        public ProjectService(BaseRepository<Project> projectRepository) : base(projectRepository)
        {
        }

        public IEnumerable<Project> GetAllByUserId(Guid userId)
        {
            return this.GetRepository().GetAllByUserId(userId);
        }

        protected override IProjectRepository GetRepository()
        {
            return (IProjectRepository)base.GetRepository();
        }
    }
}
