using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSiteProject.Common.DTOs.Article;
using WebSiteProject.Core.Services;

namespace WebSiteProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articleservice;


        public ArticlesController(IArticleService articleService)
        {
            _articleservice = articleService;
        }


        [HttpPost]
        public IActionResult AddArticle(AddArticleDto dto)
        {
            _articleservice.AddArticle(dto);

            return Ok();
        }

        [HttpPost("Update Article")]
        public IActionResult UpdateArticle(UpdateDto dto)
        {

            _articleservice.UpdateArticle(dto);
            return Ok();
        }

        [HttpPost("Delete Article")]
        public IActionResult DeleteArticle(DeleteDto dto)
        {
            _articleservice.DeleteArticle(dto);
            return Ok();
        }

        [HttpGet]

        public IActionResult GetById(int id)
        {
            ArticleDto dto = _articleservice.GetArticleById(id);
            return Ok(dto);
        }

        [HttpGet("getall")]//parantez içerisinde bir string ifade verirsen buna endpoint denir iki tane get,pos,put.. olamaz bundan dolayı endpoint kullandık 
        public IActionResult GetAll()
        {
            List<ArticleDto> list = _articleservice.GetAllArticles();
            return Ok(list);
        }

    }
}
