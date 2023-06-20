using System;
using WebSiteProject.Common.DTOs.Ticket;

namespace WebSiteProject.Core.Services
{
	public interface ITicketService
	{

		void AddTicket(AddTicketDto dto);
		void UpdateTicket(UpdateTicketDto dto);
		void DeletTicket(DeleteTicketDto dto);
		TicketDto GetTicketById(int id);
		List<TicketDto> GetAllTickets();
	}
}

