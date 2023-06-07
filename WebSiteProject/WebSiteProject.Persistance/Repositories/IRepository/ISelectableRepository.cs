using System;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.Repositories.IRepository
{
	public interface ISelectableRepository<T> : IRepository<T> where T : class,IEntity
	{

		T Get(int id);
		List<T> GetAll();
	}
}

