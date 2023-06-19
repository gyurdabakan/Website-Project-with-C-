using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.EntityConfiguration
{
	public class IssuingConfiguration : IEntityTypeConfiguration<Issuing>
    {


        public void Configure(EntityTypeBuilder<Issuing> builder)
        {
            builder.ToTable("Issuings").HasKey(k => k.Id);
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.publisherName).HasColumnName("PublisherName");
            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(p => p.UpdateDate).HasColumnName("UpdateDate");
            builder.Property(p => p.IsActive).HasColumnName("IsActive");
        }
    
    }
}

