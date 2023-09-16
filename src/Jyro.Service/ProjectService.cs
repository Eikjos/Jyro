using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Service;
using Jyro.Service.Base;

namespace Jyro.Service
{
    public class ProjectService : CrudService<IProjectRepository, Project>, IProjectService
    {
        public ProjectService(IProjectRepository projectRepository) : base(projectRepository)
        {
        }

        public IEnumerable<Project> GetAllByUserId(Guid userId, string? search)
        {
            return this.GetRepository().GetAllByUserId(userId, search);
        }
    }
}
