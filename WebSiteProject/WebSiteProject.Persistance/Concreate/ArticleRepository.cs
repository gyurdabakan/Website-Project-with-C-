using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;
using WebSiteProject.Persistance.Contexts;
using WebSiteProject.Persistance.Repositories;

namespace WebSiteProject.Persistance.Concreate
{
    public class ArticleRepository : EfBaseRepository<Articles, BaseDBContext>, IArticleRepository

    {

		public ArticleRepository(BaseDBContext context) : base(context)
		{


		}

	}
}

