using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSiteProject.Common.DTOs.Issuing;
using WebSiteProject.Core.Services;

namespace WebSiteProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuingController : ControllerBase
    {
        private readonly IIssuingService _ıssuingservice;

        public IssuingController(IIssuingService ıssuingService)
        {
            _ıssuingservice = ıssuingService;
        }

        [HttpPost]
        public IActionResult AddIssuing(AddIssuingDto dto)
        {
            _ıssuingservice.AddIssuing(dto);
            return Ok();
        }

        [HttpPost("Update Issuing")]
        public IActionResult UpdateIssuing(UpdateIssuingDto dto)
        {
            _ıssuingservice.UpdateIssuing(dto);
            return Ok();

        }

        [HttpPost("Delete Issuing")]
        public IActionResult DeleteIssuing(DeleteIssuingDto dto)
        {
            _ıssuingservice.DeleteIssuing(dto);
            return Ok();

        }


        [HttpGet("Get All Issuings")]
        public IActionResult GetAllIssuings()
        {
            List<IssuingDto> list = _ıssuingservice.GetAllIssuings();

            return Ok(list);
        }

        [HttpGet("Get Issuing ById")]
        public IActionResult GetIssuingById(int id)
        {
            IssuingDto dto = _ıssuingservice.GetIssuingById(id);
            return Ok(dto);

        }


    }
}
