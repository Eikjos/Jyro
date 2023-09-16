using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using AutoMapper.Execution;
using AutoMapper.Internal;
using Jyro.API.Model.Project.Create;
using Jyro.API.Model.Sprint.Create;
using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Service;

namespace Jyro.API.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectModel, Project>();
        }
    }
}

