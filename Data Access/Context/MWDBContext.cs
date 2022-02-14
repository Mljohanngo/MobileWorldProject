using Data_Access.Configuration;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Context
{
    public class MWDBContext : DbContext
    {
        public MWDBContext()
        {

        }

        public MWDBContext(DbContextOptions<MWDBContext> options)
            : base(options)
        {

        }

        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<MWSendPin> SendPin { get; set; }
        public DbSet<MWConfirmPin> ConfirmPin { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SubscriptionConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new MWSendPinConfig());
            modelBuilder.ApplyConfiguration(new MWConfirmPinConfig());
        }

    }
}
