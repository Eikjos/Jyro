using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Service
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _ProjectRepository;
        public ProjectService(IProjectRepository projectRepository) 
        {
            this._ProjectRepository = projectRepository;
        }

        public Project Create(Project project)
        {
            return _ProjectRepository.Insert(project);
        }

        public IEnumerable<Project> GetAllByUserId(Guid userId)
        {
            return _ProjectRepository.GetAllByUserId(userId);
        }
    }
}
