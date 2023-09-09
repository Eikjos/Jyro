using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Core.Interfaces.Repository.Base
{
    public interface ICrudRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T? GetById(Guid Id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(Guid Id);
        void Save();
    }
}
