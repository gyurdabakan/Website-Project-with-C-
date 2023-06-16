using System;
using System.Reflection.Metadata;
using WebSiteProject.Common.DTOs.Article;
using WebSiteProject.Core.Services;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;

namespace WebSiteProject.Core.Managers
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleManager(IArticleRepository articleRepository)//Dependency Injection yaptık 
        {
            _articleRepository = articleRepository;
        }

        public void AddArticle(AddArticleDto dto)
        {
            try
            {


                Articles article = new Articles();
                article.Title = dto.Title;
                article.Content = dto.Content;
                article.UpdateDate = dto.UpdateDate;
                article.CreatedDate = dto.CreateDate;
                article.IsActive = dto.IsActive;
                article.Published = dto.Published;
                article.PublishedAt = dto.PublishedAt;


                _articleRepository.Add(article);
                _articleRepository.SaveChanges();

            }
            catch (Exception ex)
            {

            }


        }

        public void DeleteArticle(DeleteDto dto)
        {
            Articles articles = new Articles();
            articles.Id = dto.Id;

            _articleRepository.Delete(articles);
            _articleRepository.SaveChanges();


        }

        public List<ArticleDto> GetAllArticles()
        {
            List<Articles> list = _articleRepository.GetAll();


            //List<ArticleDto> returntype = (from article in list
            //                               select new ArticleDto()
            //                               {
            //                                   Id = article.Id,
            //                                   Title = article.Title,
            //                                   Content = article.Content,
            //                                   UpdateDate = article.UpdateDate,
            //                                   CreateDate = article.CreatedDate,
            //                                   IsActive = article.IsActive,
            //                                   Published = article.Published,
            //                                   PublishedAt = article.PublishedAt,

            //                               }).ToList();  aynı işlemin farklı yöntemi 

            return list.Select(article => new ArticleDto()//articleları article dtoya çevirdi 
            {
                Id = article.Id,
                Title = article.Title,
                Content = article.Content,
                UpdateDate = article.UpdateDate,
                CreateDate = article.CreatedDate,
                IsActive = article.IsActive,
                Published = article.Published,
                PublishedAt = article.PublishedAt,

            }).ToList();
        }

        public ArticleDto GetArticleById(int Id)
        {
            Articles article = _articleRepository.Get(Id);
            return new ArticleDto()
            {
            Id = article.Id,
            Title = article.Title,
            Content = article.Content,
            UpdateDate = article.UpdateDate,
            CreateDate = article.CreatedDate,
            IsActive = article.IsActive,
            Published = article.Published,
            PublishedAt = article.PublishedAt,
        };

        }

        public void UpdateArticle(UpdateDto dto)
        {

            try
            {
                Articles articles = new Articles();
                articles.Id = dto.Id;
                articles.Title = dto.Title;
                articles.Content = dto.Content;
                articles.UpdateDate = dto.UpdateDate;
                articles.CreatedDate = dto.CreateDate;
                articles.IsActive = dto.IsActive;
                articles.Published = dto.Published;
                articles.PublishedAt = dto.PublishedAt;




                _articleRepository.Update(articles);
                _articleRepository.SaveChanges();
            }
            catch (Exception ex)
            {

            }
           
        }
    }
}

