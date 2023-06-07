using System;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.Repositories.IRepository
{
	public interface IRepository<T> where T : class, IEntity
    {
		int SaveChanges();
	}
}

