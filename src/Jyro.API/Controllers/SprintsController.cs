using AutoMapper;
using Jyro.API.Attribute;
using Jyro.API.Controllers.Base;
using Jyro.API.Model.Project.Create;
using Jyro.API.Model.Sprint.Create;
using Jyro.Core.Entities;
using Jyro.Core.Enum;
using Jyro.Core.Interfaces.Service;
using Jyro.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jyro.API.Controllers
{
    public class SprintsController : BaseAPIController
    {
        private readonly ISprintService _SprintService;
        private readonly IProjectService _ProjectService;
        private readonly IMapper _mapper;
        public SprintsController(ISprintService sprintService, IProjectService  projectService, IMapper mapper)
        {
            _SprintService = sprintService;
            _ProjectService = projectService;
            _mapper = mapper;
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

            var sprint = _mapper.Map<SprintModel, Sprint>(model);
            sprint.Order = project.Sprints != null ? project.Sprints.Count() : 1;

           sprint = _SprintService.Create(sprint);

            return Ok(new SprintModel
            {
                Id = sprint.Id,
                Name = sprint.Name,
                Description = sprint.Description,
                Start = sprint.Start,
                End = sprint.End,
                ProjectId = sprint.Project.Id,
            });
        }

        [Authorize]
        [HttpGet("get-by-project")]
        public IActionResult GetByProject([FromQuery] Guid projectId)
        {
            var sprints = _SprintService.GetByProjectId(projectId);
            return Ok(sprints);
        }
    }
}
