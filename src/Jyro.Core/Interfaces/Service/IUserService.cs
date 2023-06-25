using Jyro.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Interfaces.Service
{
    public interface IUserService
    {
        User? GetById(Guid Id);
    }
}
