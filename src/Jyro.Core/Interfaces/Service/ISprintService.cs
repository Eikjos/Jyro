using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Core.Interfaces.Service.Base;

namespace Jyro.Core.Interfaces.Service
{
    
    public interface ISprintService : ICrudService<ISprintRepository, Sprint>
    {
        IEnumerable<Sprint> GetByProjectId(Guid projectId);
    }
}
