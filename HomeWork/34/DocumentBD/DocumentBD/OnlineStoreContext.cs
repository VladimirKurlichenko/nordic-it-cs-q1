using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentBD
{
    class OnlineStoreContext : DbContext
    {
        private const string ConnectionString =
           "Server=tcp:shadow-art.database.windows.net,1433;" +
           "Initial Catalog=reminder;" +
           "Persist Security Info=False;" +
           "User ID=v_kurlichenko;" +
           "Password=oQ0L4tAKdowF70q8ZaA4;" +
           "Encrypt=True;";

        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<DocumentStatus> DocumentStatuses { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Contractor> Contractors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnEntityModelCreating(modelBuilder.Entity<Address>());
            OnEntityModelCreating(modelBuilder.Entity<City>());
            OnEntityModelCreating(modelBuilder.Entity<DocumentStatus>());
            OnEntityModelCreating(modelBuilder.Entity<Document>());
            OnEntityModelCreating(modelBuilder.Entity<Contractor>());

        }

        private void OnEntityModelCreating(EntityTypeBuilder<Address> entityTypeBuilder)
        {
            entityTypeBuilder.Property(_ => _.Id).ValueGeneratedOnAdd();
            entityTypeBuilder.Property(_ => _.AddressCity).HasMaxLength(128);
            entityTypeBuilder.Property(_ => _.City).HasMaxLength(128);

        }
        private void OnEntityModelCreating(EntityTypeBuilder<City> entityTypeBuilder)
        {
            entityTypeBuilder.Property(_ => _.Id).ValueGeneratedOnAdd();
            entityTypeBuilder.Property(_ => _.Name).HasMaxLength(128);
        }
        private void OnEntityModelCreating(EntityTypeBuilder<DocumentStatus> entityTypeBuilder)
        {
            entityTypeBuilder.Property(_ => _.Id).ValueGeneratedOnAdd();
            entityTypeBuilder.Property(_ => _.Status).HasMaxLength(128);
            entityTypeBuilder
                .HasOne(_ => _.Sender)
                .WithMany(_ => _.DocumentsSender);
            entityTypeBuilder
                .HasOne(_ => _.Receiver)
                .WithMany(_ => _.DocumentsReceiver);
            entityTypeBuilder
                .HasOne(_ => _.Document)
                .WithMany(_ => _.Documents);
            entityTypeBuilder.Property(_ => _.DateTime);


        }
        private void OnEntityModelCreating(EntityTypeBuilder<Document> entityTypeBuilder)
        {
            entityTypeBuilder.Property(_ => _.Id).ValueGeneratedOnAdd();
            entityTypeBuilder.Property(_ => _.Pages);
            entityTypeBuilder.Property(_ => _.Name).HasMaxLength(256);
            entityTypeBuilder.Property(_ => _.Type).HasMaxLength(128);
        }
        private void OnEntityModelCreating(EntityTypeBuilder<Contractor> entityTypeBuilder)
        {
            entityTypeBuilder.Property(_ => _.Id).ValueGeneratedOnAdd();
            entityTypeBuilder.Property(_ => _.FullName).HasMaxLength(128);
            entityTypeBuilder.Property(_ => _.Position).HasMaxLength(128);
            entityTypeBuilder
                .HasOne(_ => _.Address)
                .WithMany(_ => _.Contractors);
        }
    }
}
