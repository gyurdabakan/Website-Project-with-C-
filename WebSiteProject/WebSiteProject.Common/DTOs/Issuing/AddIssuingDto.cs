using System;
namespace WebSiteProject.Common.DTOs.Issuing
{
	public class AddIssuingDto
	{
		public string publisherName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}

