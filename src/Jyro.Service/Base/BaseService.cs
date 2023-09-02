using System;
using Jyro.Core.Interfaces.Repository.Base;
using Jyro.Core.Interfaces.Service.Base;
using Jyro.Infra.Repository.Base;

namespace Jyro.Service.Base
{
	public abstract class BaseService<T, E> : IBaseService<T, E> where T : IRepository<E> where E : class
	{
		private readonly T _Repository;

		public BaseService(T repository)
		{
			this._Repository = repository;
		}

        public E Create(E entity)
        {
            return this._Repository.Insert(entity);
        }

        public void Delete(Guid id)
        {
            this._Repository.Delete(id);
        }

        public E? GetById(Guid id)
        {
            return this._Repository.GetById(id);
        }

        public T GetRepository()
        {
            return this._Repository;
        }

        public E Update(E entity)
        {
            return this._Repository.Update(entity);
        }

        public IEnumerable<E> GetAll()
        {
            return this._Repository.GetAll();
        }
    }
}

