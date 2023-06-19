using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.EntityConfiguration
{
	public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {


        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments").HasKey(k => k.Id);
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Title).HasColumnName("Title");
            builder.Property(p => p.commentContext).HasColumnName("CommentContext");
            builder.Property(p => p.User).HasColumnName("User");
            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(p => p.UpdateDate).HasColumnName("UpdateDate");
            builder.Property(p => p.IsActive).HasColumnName("IsActive");
        }
    
    }
}

