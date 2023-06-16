using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Repositories.IRepository;

namespace WebSiteProject.Persistance.Abstract
{
	public interface IArticleRepository :IRepository<Articles>, IAddableRepository<Articles>, IDeletableRepository<Articles>,
                                IUpdatableRepository<Articles>, ISelectableRepository<Articles>
    {

	}
}

