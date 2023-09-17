using Jyro.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RoleType Role { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Commentary> CommentariesWrote { get; set; }
        public virtual ICollection<Commentary> CommentaryMentionned { get; set; }
        public virtual ICollection<RequestInviteProject> RequestInviteProjects { get; set; }
    }
}
