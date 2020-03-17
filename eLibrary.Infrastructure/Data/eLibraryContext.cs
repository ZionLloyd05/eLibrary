using eLibrary.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eLibrary.Infrastructure.Data
{
    public class eLibraryContext : DbContext
    {
        public eLibraryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<CheckoutHistory> CheckoutHistories { get; set; }
        public DbSet<LibraryBranch> LibraryBranches { get; set; }
        public DbSet<BranchHours> BranchHours { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<LibraryAsset> LibraryAssets { get; set; }
        public DbSet<Hold> Holds { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Patron>(ConfigurePatron);
            base.OnModelCreating(builder);
        }

        public void ConfigurePatron(EntityTypeBuilder<Patron> patronConfig)
        {
            patronConfig.OwnsOne(o => o.Address)
                .Property(p => p.Street).HasColumnName("Street");

            patronConfig.OwnsOne(o => o.Address)
                .Property(p => p.City).HasColumnName("City");
        }
    }
}
