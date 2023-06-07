using System;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.Repositories.IRepository
{
	public interface IAddableRepository<T> : IRepository<T> where T : class,IEntity
    {

		void Add(T entity);

	}
}

