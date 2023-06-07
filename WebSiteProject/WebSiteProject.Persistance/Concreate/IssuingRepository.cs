using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;
using WebSiteProject.Persistance.Contexts;
using WebSiteProject.Persistance.Repositories;

namespace WebSiteProject.Persistance.Concreate
{
	public class IssuingRepository : EfBaseRepository<Issuing,BaseDBContext> , IIssuingRepository
	{


		public IssuingRepository(BaseDBContext context) : base(context)
		{

		}
	}
}

