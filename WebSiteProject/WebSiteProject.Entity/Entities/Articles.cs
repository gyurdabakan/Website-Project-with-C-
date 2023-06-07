using System;
namespace WebSiteProject.Entity.Entities
{
	public class Articles : BaseEntity 
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public bool Published { get; set; }
		public DateTime? PublishedAt { get; set; }



		public Articles()
		{

		}

        public Articles(int id ,string title, string content, bool published, DateTime? publishedAt) :this()
        {
			Id = id;
            Title = title;
            Content = content;
            Published = published;
            PublishedAt = publishedAt;
        }
    }
}

