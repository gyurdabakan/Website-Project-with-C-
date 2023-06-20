using System;
using WebSiteProject.Common.DTOs.Article;
using WebSiteProject.Common.DTOs.Comment;
using WebSiteProject.Core.Services;
using WebSiteProject.Entity.Entities;
using WebSiteProject.Persistance.Abstract;

namespace WebSiteProject.Core.Managers
{
	public class CommentManager:ICommentService
	{
		private readonly ICommentRepository _commentRepository;

        public CommentManager(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;

        }

        public void AddComment(AddCommentDto dto)
        {

            try
            {
                Comment comment = new Comment();
                comment.User = dto.User;
                comment.Title = dto.Title;
                comment.commentContext = dto.commentContext;
                comment.CreatedDate = dto.CreateDate;
                comment.IsActive = dto.IsActive;
                comment.UpdateDate = dto.UpdateDate;

                _commentRepository.Add(comment);
                _commentRepository.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            



            
        }

        public void DeleteComment(DeleteCommentDto dto)
        {

            Comment comment = new Comment();
            comment.Id = dto.Id;

            _commentRepository.Delete(comment);
            _commentRepository.SaveChanges();
        }

        public List<CommentDto> GetAllCOmments()
        {
            List<Comment> list = _commentRepository.GetAll();

            return list.Select(comment => new CommentDto()
            {
                Id=comment.Id,
                User=comment.User,
                Title=comment.Title,
                commentContext=comment.commentContext,
                CreateDate=comment.CreatedDate,
                UpdateDate=comment.UpdateDate,
                IsActive=comment.IsActive



            }).ToList();
        }

        public CommentDto GetCommentById(int id)
        {
            Comment comment = _commentRepository.Get(id);

            return new CommentDto()
            {
                Id = comment.Id,
                User = comment.User,
                Title = comment.Title,
                commentContext = comment.commentContext,
                CreateDate = comment.CreatedDate,
                UpdateDate = comment.UpdateDate,
                IsActive = comment.IsActive
            };
        }

        public void UpdateComment(UpdateCommentDto dto)
        {
            Comment comment = new Comment();
            comment.Id = dto.Id;
            comment.User = dto.User;
            comment.Title = dto.Title;
            comment.commentContext = dto.commentContext;
            comment.CreatedDate = dto.CreateDate;
            comment.IsActive = dto.IsActive;
            comment.UpdateDate = dto.UpdateDate;

            _commentRepository.Update(comment);
            _commentRepository.SaveChanges();


        }
    }
}

