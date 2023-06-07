using System;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.Repositories.IRepository
{
	public interface IUpdatableRepository<T> : IRepository<T> where T :class,IEntity
	{

		void Update(T entity);

	}
}

