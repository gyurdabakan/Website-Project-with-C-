using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Contexts;
using WebSiteProject.Persistance.Repositories;
using WebSiteProject.Persistance.Repositories.IRepository;

namespace WebSiteProject.Persistance.Abstract
{
	public interface IIssuingRepository : IRepository<Issuing>, IAddableRepository<Issuing>, IDeletableRepository<Issuing>,
                                IUpdatableRepository<Issuing>, ISelectableRepository<Issuing>
    {

	}
}

