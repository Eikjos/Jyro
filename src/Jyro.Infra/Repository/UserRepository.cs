﻿using Jyro.Core.Entities;
using Jyro.Core.Interfaces.Repository;
using Jyro.Infra.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Infra.Repository
{
    public class UserRepository : CrudRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext AppDbContext) : base(AppDbContext)
        {
        }

        public User? GetByEmail(string Email)
        {
            return GetAll().FirstOrDefault(u => u.Email == Email);
        }
    }
}
