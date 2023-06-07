using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.EntityConfiguration
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Articles>
    {
        public void Configure(EntityTypeBuilder<Articles> builder)
        {
            builder.ToTable("Articles").HasKey(k => k.Id);//Tablomuza ad verdik ve pk ini idye eşitledik
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.Title).HasColumnName("Title");
            builder.Property(p => p.Content).HasColumnName("Content");
            builder.Property(p => p.Published).HasColumnName("Published");
            builder.Property(p => p.PublishedAt).HasColumnName("Publishedat");
            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(p => p.UpdateDate).HasColumnName("UpdateDate");
            builder.Property(p => p.IsActive).HasColumnName("IsActive");
        }
    }
}

