using Jyro.API.Attribute;
using Jyro.API.Controllers.Base;
using Jyro.API.Model.Project.Create;
using Jyro.API.Model.User.Register;
using Jyro.Core.Entities;
using Jyro.Core.Enum;
using Jyro.Core.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jyro.API.Controllers
{
    [ApiController]
    public class ProjectsController : BaseAPIController
    {
        private readonly IProjectService _ProjectService;
        public ProjectsController(IProjectService projectService) 
        {
            this._ProjectService = projectService;
        }

        [HttpPost]
        [Authorize]
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

        [HttpGet("get-by-user")]
        [Authorize]
        [AuthorizeRole(new[] { RoleType.PRODUCT_OWNER, RoleType.USER, RoleType.ADMIN})]
        public IActionResult GetAllByUserId()
        {
            var userId = (Guid) HttpContext.Items["UserId"];
            return Ok(_ProjectService.GetAllByUserId(userId));
        }

        [HttpGet("get-by-id")]
        [Authorize]
        public IActionResult GetById([FromQuery] Guid id)
        {
            return Ok(_ProjectService.GetById(id));
        }
    }
}
