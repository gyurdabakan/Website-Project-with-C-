using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSiteProject.Common.DTOs.Ticket;
using WebSiteProject.Core.Services;

namespace WebSiteProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {

        private readonly ITicketService _ticketservice;

        public TicketController(ITicketService ticketService)
        {
            _ticketservice = ticketService;
        }


        [HttpPost("Add Ticket")]
        public IActionResult AddTicket(AddTicketDto dto)
        {
            _ticketservice.AddTicket(dto);
            return Ok();
        }


        [HttpPost("Update Ticket")]
        public IActionResult UpdateTicket(UpdateTicketDto dto)
        {
            _ticketservice.UpdateTicket(dto);
            return Ok();
        }

        [HttpPost("Delete Ticket")]
        public IActionResult DeleteTicket(DeleteTicketDto dto)
        {
            _ticketservice.DeletTicket(dto);
            return Ok();

        }


        [HttpGet("Get All Tickets")]
        public IActionResult GetAllTickets(TicketDto dto)
        {
            List<TicketDto> list = _ticketservice.GetAllTickets();
            return Ok(list);
        }

        [HttpGet("Get Ticket ById")]
        public IActionResult GetTicketById(int id)
        {
            TicketDto dto = _ticketservice.GetTicketById(id);
            return Ok(dto);
        }


    }
}
