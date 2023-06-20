using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSiteProject.Common.DTOs.Comment;
using WebSiteProject.Core.Services;

namespace WebSiteProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;


        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }


        [HttpPost]
        public IActionResult AddComment(AddCommentDto dto)
        {
            _commentService.AddComment(dto);
            return Ok();

        }


        [HttpPost("Comment Update")]
        public IActionResult UpdateComment(UpdateCommentDto dto)
        {
            _commentService.UpdateComment(dto);
            return Ok();
        }

        [HttpPost("Delete Comment")]
        public IActionResult DeleteComment(DeleteCommentDto dto)
        {
            _commentService.DeleteComment(dto);
            return Ok();

        }

        [HttpGet]

        public IActionResult GetAllComments(CommentDto dto)
        {
            List<CommentDto> list = _commentService.GetAllCOmments();
            return Ok(list);
        }

        [HttpGet("Get Comment By Id")]
        public IActionResult GetById(int id)
        {
            CommentDto dto = _commentService.GetCommentById(id);
            return Ok(dto);
        }

    }
}
