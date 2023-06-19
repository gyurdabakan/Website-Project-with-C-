using System;
namespace WebSiteProject.Common.DTOs.Category
{
	public class AddCategoryDto
	{


        public string CategoryName { get; set; }
        public bool Published { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }

    }
}

