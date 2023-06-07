using System;
namespace WebSiteProject.Entity.Entities
{
	public class Category : BaseEntity
	{
		public string categoryName { get; set; }
        public bool Published { get; set; }
        public DateTime? PublishedAt { get; set; }


		public Category()
		{
		}

		public Category(int id , string categoryName,bool published, DateTime? publishedAt) : this ()
		{
			Id = id;
			categoryName = categoryName;
			Published = published;
			PublishedAt = publishedAt;
			



		}
	}
}

