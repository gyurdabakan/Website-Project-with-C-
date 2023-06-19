using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSiteProject.Common.DTOs.Category;
using WebSiteProject.Core.Services;

namespace WebSiteProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]

        public IActionResult AddCategory(AddCategoryDto dto)
        {
            _categoryService.AddCategory(dto);
            return Ok();

        }

        [HttpPost("Update Category")]

        public IActionResult UpdateCategory(UpdateCategoryDto dto)
        {
            _categoryService.UpdateCategory(dto);
            return Ok();

        }


        [HttpPost("Delete Category")]
        public IActionResult DeleteCategory(DeleteCategoryDto dto)
        {

            _categoryService.DeleteCategory(dto);

            return Ok();
        }

        [HttpGet("Get All")]
        public IActionResult GetAll(CategoryDto dto)
        {
            List<CategoryDto> list = _categoryService.GetAllCategories();

            return Ok(list);
        }

        [HttpGet]

        public IActionResult GetById(int id)
        {
            CategoryDto dto = _categoryService.GetCategoryById(id);

            return Ok(dto);

        }
    }
}
