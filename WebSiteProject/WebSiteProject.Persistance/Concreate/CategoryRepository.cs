using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;
using WebSiteProject.Persistance.Contexts;
using WebSiteProject.Persistance.Repositories;

namespace WebSiteProject.Persistance.Concreate
{
	public class CategoryRepository : EfBaseRepository<Category , BaseDBContext> , ICategoryRepository
	{

		public CategoryRepository(BaseDBContext context) : base(context)
		{

		}

	}
}

