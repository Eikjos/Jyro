using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Service;
using Jyro.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Service
{
    public class SprintService : CrudService<ISprintRepository, Sprint>, ISprintService
    {
        public SprintService(ISprintRepository repository) : base(repository)
        {
        }
    }
}
