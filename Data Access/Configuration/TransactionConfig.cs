using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Configuration
{
    internal class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.Property(x => x.TransactionId).HasColumnType("varchar(30)");

            builder.Property(x => x.Msisdn).HasColumnType("varchar(15)");

            builder.Property(x => x.BillType).HasColumnType("varchar(20)");

            builder.Property(x => x.KeyWord).HasColumnType("varchar(20)");

            builder.Property(x => x.BillType).HasColumnType("varchar(10)");

            builder.HasIndex(i => new { i.Msisdn })
                    .HasDatabaseName("IDX_Msisdn");

            builder.HasIndex(i => new { i.Msisdn, i.BillType })
                    .HasDatabaseName("IDX_Msisdn_BillType");

        }
    }
}
