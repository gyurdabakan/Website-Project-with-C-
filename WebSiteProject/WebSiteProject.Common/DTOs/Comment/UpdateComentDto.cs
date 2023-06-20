using System;
namespace WebSiteProject.Common.DTOs.Comment
{
	public class UpdateCommentDto
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string commentContext { get; set; }
        public string User { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}

