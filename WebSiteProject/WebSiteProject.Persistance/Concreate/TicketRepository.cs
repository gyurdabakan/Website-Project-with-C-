using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;
using WebSiteProject.Persistance.Contexts;
using WebSiteProject.Persistance.Repositories;

namespace WebSiteProject.Persistance.Concreate
{
	public class TicketRepository : EfBaseRepository<Ticket , BaseDBContext> , ITicketRepository
	{


		public TicketRepository(BaseDBContext context) : base(context)
		{

		}

	}
}

