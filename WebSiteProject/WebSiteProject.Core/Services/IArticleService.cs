using System;
using WebSiteProject.Common.DTOs.Article;

namespace WebSiteProject.Core.Services
{
	public interface IArticleService
	{

		void AddArticle(AddArticleDto dto);
		void UpdateArticle(UpdateDto dto);
		void DeleteArticle(DeleteDto dto);
		ArticleDto GetArticleById(int id);
		List<ArticleDto> GetAllArticles();

	}
}

