using Jyro.API.Attribute;
using Jyro.API.Controllers.Base;
using Jyro.API.Model.Project.Create;
using Jyro.API.Model.Sprint.Create;
using Jyro.Core.Entities;
using Jyro.Core.Enum;
using Jyro.Core.Interfaces.Service;
using Jyro.Service;
using Microsoft.AspNetCore.Mvc;

namespace Jyro.API.Controllers
{
    public class SprintsController : BaseAPIController
    {
        private readonly ISprintService _SprintService;
        private readonly IProjectService _ProjectService;
        public SprintsController(ISprintService sprintService, IProjectService  projectService)
        {
            _SprintService = sprintService;
            _ProjectService = projectService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_SprintService.GetAll());
        }

        [AuthorizeRole(new[] { RoleType.USER, RoleType.PRODUCT_OWNER })]
        [HttpPost]
        public IActionResult Create([FromBody] SprintModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var project = _ProjectService.GetById(model.ProjectId);
            if (project == null)
                return BadRequest("project.not.exist");

            var mapper = Jyro.API.Helper.AutoMapper.GetMapper<ProjectModel, Project>();
            var sprint = mapper.Map<Sprint>(model);

            sprint = _SprintService.Create(sprint);

            return Ok(sprint);
        }
    }
}
