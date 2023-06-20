using System;
using WebSiteProject.Common.DTOs.Ticket;
using WebSiteProject.Core.Services;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;

namespace WebSiteProject.Core.Managers
{
	public class TicketManager :ITicketService
	{
        private readonly ITicketRepository _ticketRepository;

		public TicketManager(ITicketRepository ticketRepository)
		{

            _ticketRepository = ticketRepository;
		}

        public void AddTicket(AddTicketDto dto)
        {
            try
            {
                Ticket ticket = new Ticket();
                ticket.ticketType = dto.TicketType;
                ticket.CreatedDate = dto.CreateDate;
                ticket.UpdateDate = dto.UpdateDate;
                ticket.IsActive = dto.IsActive;

                _ticketRepository.Add(ticket);
                _ticketRepository.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            
        }

        public void DeletTicket(DeleteTicketDto dto)
        {
            Ticket ticket = new Ticket();
            ticket.Id = dto.Id;

            _ticketRepository.Delete(ticket);
            _ticketRepository.SaveChanges();
        }

        public List<TicketDto> GetAllTickets()
        {
            List<Ticket> list = _ticketRepository.GetAll();

            return list.Select(ticket => new TicketDto()
            {

                Id = ticket.Id,
                TicketType=ticket.ticketType,
                CreateDate=ticket.CreatedDate,
                UpdateDate=ticket.UpdateDate,
                IsActive=ticket.IsActive,

            }).ToList();
        }

        public TicketDto GetTicketById(int id)
        {
            Ticket ticket = _ticketRepository.Get(id);

            return new TicketDto()
            {
                Id = ticket.Id,
                TicketType = ticket.ticketType,
                CreateDate = ticket.CreatedDate,
                UpdateDate = ticket.UpdateDate,
                IsActive = ticket.IsActive,

            };

        }

        public void UpdateTicket(UpdateTicketDto dto)
        {
            try
            {

                Ticket ticket = new Ticket();
                ticket.Id = dto.Id;
                ticket.ticketType = dto.TicketType;
                ticket.CreatedDate = dto.CreateDate;
                ticket.UpdateDate = dto.UpdateDate;
                ticket.IsActive = dto.IsActive;

                _ticketRepository.Update(ticket);
                _ticketRepository.SaveChanges();




            }
            catch (Exception ex)
            {

            }
        }
    }
}

