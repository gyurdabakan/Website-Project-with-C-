using System;
namespace WebSiteProject.Entity.Entities
{
	public class Comment : BaseEntity
	{
		public string Title { get; set; }

		public string commentContext { get; set; }

		public string User { get; set; }


		public Comment()
		{
		}

		public Comment(int id , string Title , string commentContext , string User, DateTime createDate , DateTime updateDate) : this()
		{
			Id = id;
			Title = Title;
			commentContext = commentContext;
			User = User;
			createDate = createDate;
			updateDate = updateDate;
		}
	}
}

