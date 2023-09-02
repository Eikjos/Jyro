using System;
using Jyro.Core.Interfaces.Repository.Base;

namespace Jyro.Core.Interfaces.Service.Base
{
	public interface IBaseService<T> where T : class
	{
		T Create(T entity);
		T Update(T entity);
		void Delete(Guid id);
		T? GetById(Guid id);
		IEnumerable<T> GetAll();
		extern virtual IRepository<T> GetRepository();
	}
}

