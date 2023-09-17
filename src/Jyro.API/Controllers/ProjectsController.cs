using AutoMapper;
using Jyro.API.Attribute;
using Jyro.API.Constants;
using Jyro.API.Controllers.Base;
using Jyro.API.Model.Project.Create;
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
        private readonly IUserService _UserService;
        private readonly IMapper _mapper;
        public ProjectsController(IProjectService projectService, IUserService userService, IMapper mapper) 
        {
            _ProjectService = projectService;
            _UserService = userService;
            _mapper = mapper;
        }

        [HttpPost]
        [Authorize]
        [AuthorizeRole(new[] { RoleType.PRODUCT_OWNER, RoleType.ADMIN, RoleType.USER })]
        public IActionResult Create([FromBody] ProjectModel model) 
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = _UserService.GetById((Guid) HttpContext.Items[AppConstant.USER_ID_TOKEN]);
            var project = _mapper.Map<ProjectModel, Project>(model);
            project.Users.Add(user);

            project = _ProjectService.Create(project);

            return Ok(project);
        }

        [HttpGet("get-by-user")]
        [Authorize]
        [AuthorizeRole(new[] { RoleType.PRODUCT_OWNER, RoleType.USER, RoleType.ADMIN})]
        public IActionResult GetAllByUserId([FromQuery] string? search)
        {
            var userId = (Guid) HttpContext.Items[AppConstant.USER_ID_TOKEN];
            return Ok(_ProjectService.GetAllByUserId(userId, search));
        }

        [HttpGet("get-by-id")]
        [Authorize]
        public IActionResult GetById([FromQuery] Guid id)
        {
            return Ok(_ProjectService.GetById(id));
        }
    }
}
