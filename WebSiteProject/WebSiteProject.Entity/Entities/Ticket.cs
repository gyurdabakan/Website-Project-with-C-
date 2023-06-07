using System;
namespace WebSiteProject.Entity.Entities
{
	public class Ticket : BaseEntity
	{
		public string ticketType { get; set; }

		public Ticket()
		{
		}

		public Ticket(int id , string ticketType , DateTime createDate , DateTime updateDate) : this()
		{
			Id = id;
			ticketType = ticketType;
			createDate = createDate;
			updateDate = updateDate;

		}
	}
}

