using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Entities
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual User Responsable { get; set; }
        public virtual Column Column { get; set; }
        public virtual Sprint Sprint { get; set; }
        public TimeSpan Time { get; set; }
    }
}
