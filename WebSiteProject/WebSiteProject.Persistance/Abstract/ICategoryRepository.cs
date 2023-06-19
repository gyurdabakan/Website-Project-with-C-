using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Repositories.IRepository;

namespace WebSiteProject.Persistance.Abstract
{
	public interface ICategoryRepository : IRepository<Category>, IAddableRepository<Category>, IDeletableRepository<Category>,
                                IUpdatableRepository<Category>, ISelectableRepository<Category>
    {

	}
}

