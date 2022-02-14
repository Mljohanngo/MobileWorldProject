using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data_Access.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.AppName).HasColumnType("varchar(50)");

            builder.Property(p => p.ServiceName).HasColumnType("varchar(50)");

            builder.HasIndex(i => new { i.Key, i.PartnerId })
                .HasDatabaseName("IDX_ProductKey_PartnerId");

            builder.HasData(new Product
            {
                Id = 1,
                AppName = "megaplay",
                ServiceName = "MegaPlay",
                IsActive = true,
                PartnerId = 900,
                CreateDate = DateTime.Now,
                ContentBaseUrl = "https://megaplay.digi-vibe.com/?sugid=cd01de3a-e5ae-434c-b926-ec127d1cde3b",
                LandingPageBaseUrl = "http://uae.digi-vibe.com/"
            }); 

        }
    }
}
