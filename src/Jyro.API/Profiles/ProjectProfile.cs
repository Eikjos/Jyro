using AutoMapper;
using Jyro.API.Model.Project.Create;
using Jyro.Core.Entities;

namespace Jyro.API.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectModel, Project>().AfterMap<MappingCustomer>();
        }
    }

    public class MappingCustomer : IMappingAction<ProjectModel, Project>
    {

        public MappingCustomer()
        {
        }

        public void Process(ProjectModel source, Project destination, ResolutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}

