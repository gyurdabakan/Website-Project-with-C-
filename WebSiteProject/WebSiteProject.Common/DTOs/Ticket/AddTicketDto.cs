using System;
namespace WebSiteProject.Common.DTOs.Ticket
{
	public class AddTicketDto
	{
		public string TicketType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}

