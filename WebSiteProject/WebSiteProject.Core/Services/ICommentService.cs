using System;
using WebSiteProject.Common.DTOs.Comment;

namespace WebSiteProject.Core.Services
{
	public interface ICommentService
	{
		void AddComment(AddCommentDto dto);
		void UpdateComment(UpdateCommentDto dto);
		void DeleteComment(DeleteCommentDto dto);
		CommentDto GetCommentById(int id);
		List<CommentDto> GetAllCOmments();

	}
}

