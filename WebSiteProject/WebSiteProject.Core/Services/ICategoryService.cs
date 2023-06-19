using System;
using WebSiteProject.Common.DTOs.Category;

namespace WebSiteProject.Core.Services
{
	public interface ICategoryService
	{

		void AddCategory(AddCategoryDto dto);
		void UpdateCategory(UpdateCategoryDto dto);
		void DeleteCategory(DeleteCategoryDto dto);
		CategoryDto GetCategoryById(int id);
		List<CategoryDto> GetAllCategories();


	}
}

