using System;
using WebSiteProject.Common.DTOs.Category;
using WebSiteProject.Core.Services;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;

namespace WebSiteProject.Core.Managers
{
	public class CategoryManager :ICategoryService
	{

		private readonly ICategoryRepository _categoryRepository;


		public CategoryManager(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

        public void AddCategory(AddCategoryDto dto)
        {

            try
            {
                Category category = new Category();
                category.categoryName = dto.CategoryName;
                category.CreatedDate = dto.CreateDate;
                category.UpdateDate = dto.UpdateDate;
                category.IsActive = dto.IsActive;
                category.Published = dto.Published;
                category.PublishedAt = dto.PublishedAt;

                _categoryRepository.Add(category);
                _categoryRepository.SaveChanges();

            }
            catch (Exception ex)
            {

            }
            

        }

        public void DeleteCategory(DeleteCategoryDto dto)
        {
            Category category = new Category();
            category.Id = dto.Id;

            _categoryRepository.Delete(category);
            _categoryRepository.SaveChanges();
        }

        public List<CategoryDto> GetAllCategories()
        {

            List<Category> list = _categoryRepository.GetAll();

            return list.Select(category => new CategoryDto()
            {
                Id = category.Id,
                CategoryName = category.categoryName,
                CreateDate = category.CreatedDate,
                UpdateDate=category.UpdateDate,
                IsActive=category.IsActive,
                Published=category.Published,
                PublishedAt=category.PublishedAt

            }).ToList();

   
        }

        public CategoryDto GetCategoryById(int id)
        {
            Category category = _categoryRepository.Get(id);

            return new CategoryDto()
            {
                Id = category.Id,
                CategoryName=category.categoryName,
                CreateDate = category.CreatedDate,
                UpdateDate = category.UpdateDate,
                IsActive = category.IsActive,
                Published = category.Published,
                PublishedAt = category.PublishedAt


            };
        }

        public void UpdateCategory(UpdateCategoryDto dto)
        {
            Category category = new Category();
            category.Id = dto.Id;
            category.categoryName = dto.CategoryName;
            category.CreatedDate = dto.CreateDate;
            category.UpdateDate = dto.UpdateDate;
            category.IsActive = dto.IsActive;
            category.Published = dto.Published;
            category.PublishedAt = dto.PublishedAt;

            _categoryRepository.Update(category);
            _categoryRepository.SaveChanges();
        }
    }
}

