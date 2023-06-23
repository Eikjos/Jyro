using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Entities
{
    public class Time
    {
        public Guid Id { get; set; }
        public TimeSpan Times { get; set; }
        public virtual User User { get; set; }
        public DateTime Date { get; set; }
        public Task Task { get; set; }
        public string Commentary { get; set; }
    }
}
