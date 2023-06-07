using System;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.Repositories.IRepository
{
	public interface IDeletableRepository<T> : IRepository<T> where T : class,IEntity
	{

		void Delete(T entity);
	}
}

