using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Repositories.IRepository;

namespace WebSiteProject.Persistance.Abstract
{
	public interface ITicketRepository : IRepository<Ticket>, IAddableRepository<Ticket>, IDeletableRepository<Ticket>,
                                IUpdatableRepository<Ticket>, ISelectableRepository<Ticket>
    {
		
	}
}

