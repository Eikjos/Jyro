using System;
using Jyro.Core.Interfaces.Repository.Base;
using Jyro.Core.Interfaces.Service.Base;
using Jyro.Infra.Repository.Base;

namespace Jyro.Service.Base
{
	public abstract class BaseService<T> : IBaseService<T> where T : class
	{
		private readonly BaseRepository<T> _Repository;

		public BaseService(BaseRepository<T> baseRepository)
		{
			this._Repository = baseRepository;
		}

        public T Create(T entity)
        {
            return this._Repository.Insert(entity);
        }

        public void Delete(Guid id)
        {
            this._Repository.Delete(id);
        }

        public IEnumerable<T> GetAll()
        {
            return this._Repository.GetAll();
        }

        public T? GetById(Guid id)
        {
            return this._Repository.GetById(id);
        }

        protected virtual IRepository<T> GetRepository()
        {
            return this._Repository;
        }

        public T Update(T entity)
        {
            return this._Repository.Update(entity);
        }
    }
}

