﻿using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data_Access.Configuration
{
    public class SubscriptionConfig : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.Property(p => p.Msisdn).HasColumnType("varchar(15)");

            builder.Property(p => p.Status).HasColumnType("varchar(15)");

            builder.Property(p => p.EventSource).HasColumnType("varchar(5)");

            builder.HasIndex(i => new { i.Status, i.CreateDate })
                .HasDatabaseName("IDX_Status_CreateDate");

            builder.HasIndex(i => new { i.LastSuccessfulRenew})
                .HasDatabaseName("IDX_Last_Succ_Ren");

            builder.HasIndex(i => new { i.IdOperator})
                .HasDatabaseName("IDX_Operator");

        }
    }
}
