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
    public class ProjectRepository : CrudRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext AppDbContext) : base(AppDbContext)
        {
        }

        public IQueryable<Project> GetAllByUserId(Guid userId, string? search)
        {
            var projects = GetAll().Where(p => p.Users.Any(u => u.Id == userId));
            if (search != null)
                return projects.Where(p => p.Name.Contains(search));

            return projects;
        }
    }
}
