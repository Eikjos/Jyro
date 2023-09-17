using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Jyro.Core.Entities
{
    [PrimaryKey(nameof(UserId), nameof(ProjectId))]
    public class RequestInviteProject
    {
        [ForeignKey(nameof(User))]
        public  Guid UserId { get; set; }
        public User User { get; set; }
        [ForeignKey(nameof(Project))]
        public  Guid ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
