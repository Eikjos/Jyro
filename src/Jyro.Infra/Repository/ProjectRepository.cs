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
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext AppDbContext) : base(AppDbContext)
        {
        }

        public IQueryable<Project> GetAllByUserId(Guid userId)
        {
            return GetAll().Where(p => p.Users.Any(u => u.Id == userId));
        }
    }
}
