using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;
using WebSiteProject.Persistance.Contexts;
using WebSiteProject.Persistance.Repositories;

namespace WebSiteProject.Persistance.Concreate
{
	public class CommentRepository : EfBaseRepository<Comment , BaseDBContext> , ICommentRepository
	{

		public CommentRepository(BaseDBContext context) : base(context)
		{

		}
	}
}

