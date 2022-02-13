using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data_Access.Configuration
{
    public class SubscriptionConfig : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.HasIndex(i => new { i.Status, i.CreateDate })
                .HasDatabaseName("IDX_Status_CreateDate");

            builder.HasIndex(i => new { i.LastSuccessfulRenew})
                .HasDatabaseName("IDX_Last_Succ_Ren");

            builder.HasIndex(i => new { i.IdOperator})
                .HasDatabaseName("IDX_Operator");


        }
    }
}
