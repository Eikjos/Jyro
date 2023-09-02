using System;
using Jyro.Core.Interfaces.Repository.Base;

namespace Jyro.Core.Interfaces.Service.Base
{
	public interface IBaseService<T, E> where T : IRepository<E> where E : class
	{
		E Create(E entity);
		E Update(E entity);
		void Delete(Guid id);
		E? GetById(Guid id);
		IEnumerable<E> GetAll();
		T GetRepository();
	}
}

