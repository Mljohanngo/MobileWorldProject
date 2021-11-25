using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Data_Access;
using Entities;

#nullable disable

namespace Data_Access.Context
{
    public partial class AffiliateDBContext : DbContext
    {
        public AffiliateDBContext()
        {
        }

        public AffiliateDBContext(DbContextOptions<AffiliateDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblReferralHit> TblReferralHits { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblReferralHit>(entity =>
            {
                entity.HasKey(e => e.IdHit)
                    .HasName("v1_PK__tbl_refe__D6EA82DC4C6794CA");

                entity.ToTable("tbl_referral_hit");

                entity.HasIndex(e => new { e.IdCampaign, e.CreateDate }, "idx_ref_hit_01");

                entity.HasIndex(e => e.CreateDate, "idx_ref_hit_02");

                entity.HasIndex(e => e.Msisdn, "idx_ref_hit_03");

                entity.HasIndex(e => e.TransactionId, "idx_ref_hit_04");

                entity.Property(e => e.IdHit).HasColumnName("id_hit");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.IdCampaign).HasColumnName("id_campaign");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ip_address");

                entity.Property(e => e.Msisdn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("msisdn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Promo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("promo");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("transaction_id");

                entity.Property(e => e.UserAgent)
                    .IsUnicode(false)
                    .HasColumnName("user_agent");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
