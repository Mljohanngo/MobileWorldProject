using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data_Access.Configuration
{
    public class MWConfirmPinConfig : IEntityTypeConfiguration<MWConfirmPin>
    {
        public void Configure(EntityTypeBuilder<MWConfirmPin> builder)
        {
            builder.Property(p => p.Action).HasColumnType("varchar(2)");

            builder.Property(p => p.Msisdn).HasColumnType("varchar(15)");

            builder.Property(p => p.ProductId).HasColumnType("varchar(3)");

            builder.Property(p => p.PinCode).HasColumnType("varchar(15)");

            builder.Property(p => p.PubId).HasColumnType("varchar(2)");

            builder.Property(p => p.Channel).HasColumnType("varchar(10)");

            builder.Property(p => p.AdPartnerName).HasColumnType("varchar(30)");

            builder.Property(p => p.TrxID).HasColumnType("varchar(60)");

            builder.Property(p => p.ResultMessage).HasColumnType("varchar(250)");

            builder.Property(p => p.ResponseMessage).HasColumnType("varchar(250)");

            builder.HasIndex(i => new { i.OpSubscriptionId })
                .HasDatabaseName("IDX_OpsubscriptionId");

            builder.HasIndex(i => new { i.SubscriptionId })
                .HasDatabaseName("IDX_SubscriptionId");

            builder.HasIndex(i => new { i.Msisdn, i.CreateDate })
                .HasDatabaseName("IDX_Msisdn_CreateDate");

            builder.HasIndex(i => new { i.ResponseCode })
                .HasDatabaseName("IDX_ResponseCode");

            builder.HasIndex(i => new { i.PinCode })
                .HasDatabaseName("IDX_PinCode");
        }
    }
}
