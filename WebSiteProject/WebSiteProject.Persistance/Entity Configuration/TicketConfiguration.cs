using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.EntityConfiguration
{
	public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {


        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets").HasKey(k => k.Id);
            builder.Property(p => p.Id).HasColumnName("Id");
            builder.Property(p => p.ticketType).HasColumnName("TicketType");
            builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(p => p.UpdateDate).HasColumnName("UpdateDate");
            builder.Property(p => p.IsActive).HasColumnName("IsActive");
        }
    }
    }


