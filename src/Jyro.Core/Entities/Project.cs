﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Sprint> Sprints { get; set;}
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<RequestInviteProject> RequestInviteProjects { get; set; }
    }
}
