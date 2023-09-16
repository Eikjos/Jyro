﻿using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Infra.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Infra.Repository
{
    public class SprintRepository : CrudRepository<Sprint>, ISprintRepository
    {
        public SprintRepository(AppDbContext AppDbContext) : base(AppDbContext)
        {
        }

        public IQueryable<Sprint> GetByProjectId(Guid projectId)
        {
            return GetAll().Where(s => s.Project.Id == projectId).OrderBy(s => s.Start);
        }
    }
}
