using System;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Repositories.IRepository;

namespace WebSiteProject.Persistance.Abstract
{
	public interface ICommentRepository :IRepository<Comment>, IAddableRepository<Comment>, IDeletableRepository<Comment>,
                                IUpdatableRepository<Comment>, ISelectableRepository<Comment>
    {



	}
}

