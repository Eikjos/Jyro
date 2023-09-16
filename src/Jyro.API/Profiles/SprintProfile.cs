using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using AutoMapper.Execution;
using AutoMapper.Internal;
using Jyro.API.Model.Sprint.Create;
using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Service;

namespace Jyro.API.Profiles
{
	public class SprintProfile : Profile
	{
        public SprintProfile()
        {
            CreateMap<SprintModel, Sprint>().AfterMap<MappingProject>();
        }
	}

    public class MappingProject : IMappingAction<SprintModel, Sprint>
    {
        private readonly IProjectService service;

        public MappingProject(IProjectService _service)
        {
            service = _service;
        }

        public void Process(SprintModel source, Sprint destination, ResolutionContext context)
        {
            var project = service.GetById(source.ProjectId);
            destination.Project = project;
        }
    }
}

