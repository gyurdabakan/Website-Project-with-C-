using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.EntityConfiguration
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {


        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories").HasKey(k => k.Id);
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.categoryName).HasColumnName("CategoryName");
            builder.Property(p => p.Published).HasColumnName("Published");
            builder.Property(p => p.PublishedAt).HasColumnName("Publishedat");
            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(p => p.UpdateDate).HasColumnName("UpdateDate");
            builder.Property(p => p.IsActive).HasColumnName("IsActive");
        }

    
    }
}

