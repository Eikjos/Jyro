using Jyro.Core.Interfaces.Repository.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyro.Infra.Repository.Base
{
    public class CrudRepository<T> :ICrudRepository<T> where T : class
    {
        private readonly AppDbContext _AppDbContext;

        public CrudRepository(AppDbContext AppDbContext)
        {
            _AppDbContext = AppDbContext;
        }

        public IQueryable<T> GetAll()
        {
            return _AppDbContext.Set<T>();
        }

        public T? GetById(Guid Id)
        {
            return _AppDbContext.Find<T>(Id);
        }

        public T Insert(T entity)
        {
            T result = _AppDbContext.Set<T>().Add(entity).Entity;
            _AppDbContext.SaveChanges();
            return result;
        }

        public T Update(T entity)
        {
            T result = _AppDbContext.Update<T>(entity).Entity;
            return result;
        }

        public void Delete(Guid Id)
        {
            var item = GetById(Id);
            _AppDbContext.Set<T>().Remove(item);
            _AppDbContext.SaveChanges();
        }

        public void Save()
        {
            _AppDbContext.SaveChanges();
        }

    }
}
