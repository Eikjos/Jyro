using System.ComponentModel.DataAnnotations;

namespace Jyro.API.Model.Project.Create
{
    public class ProjectModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
    }
}
