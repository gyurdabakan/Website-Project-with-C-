using System;
namespace WebSiteProject.Common.DTOs.Article
{
	public class ArticleDto
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Published { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}

