using System;
using Jyro.Core.Interfaces.Repository.Base;

namespace Jyro.Core.Interfaces.Service.Base
{
	public interface ICrudService<T, E> where T : ICrudRepository<E> where E : class
	{
		E Create(E entity);
		E Update(E entity);
		void Delete(Guid id);
		E? GetById(Guid id);
		IEnumerable<E> GetAll();
		T GetRepository();
	}
}

