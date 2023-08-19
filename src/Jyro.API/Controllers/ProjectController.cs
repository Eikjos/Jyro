using Jyro.API.Attribute;
using Jyro.API.Controllers.Base;
using Jyro.API.Model.Project.Create;
using Jyro.API.Model.User.Register;
using Jyro.Core.Entities;
using Jyro.Core.Enum;
using Jyro.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;

namespace Jyro.API.Controllers
{
    [ApiController]
    public class ProjectController : BaseAPIController
    {
        private readonly IProjectService _ProjectService;
        public ProjectController(IProjectService projectService) 
        {
            this._ProjectService = projectService;
        }

        [HttpPost]
        [AuthorizeRole(new[] { RoleType.PRODUCT_OWNER, RoleType.ADMIN, RoleType.USER })]
        public IActionResult Create([FromBody] ProjectModel model) 
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var mapper = Jyro.API.Helper.AutoMapper.GetMapper<ProjectModel, Project>();
            var project = mapper.Map<Project>(model);

            project = _ProjectService.Create(project);

            return Ok(project);
        }
    }
}
