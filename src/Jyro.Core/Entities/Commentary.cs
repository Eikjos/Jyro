using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Entities
{
    public class Commentary
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public virtual User Author { get; set; }
        public virtual ICollection<User> Mentionned { get; set; }
        public virtual Task Task { get; set; }
    }
}
