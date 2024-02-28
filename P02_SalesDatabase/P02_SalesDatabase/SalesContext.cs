using Microsoft.EntityFrameworkCore;
using P02_SalesDatabase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase
{
    internal class SalesContext :DbContext
    {
        public DbSet<Sale> sales { get; set; }
        public DbSet<Product> products{ get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Store> stores { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.\\SQLEXPRESS; Initial Catalog =SalesDatabase; Integrated Security = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
        .Property(b => b.Description)
        .HasDefaultValue("No description");


            modelBuilder.Entity<Customer>()
       .HasMany(e => e.Sales)
       .WithOne(e => e.customer)
       .HasForeignKey(e => e.CustomerId)
       .IsRequired();


            modelBuilder.Entity<Store>()
    .HasMany(e => e.Sales)
    .WithOne(e => e.store)
    .HasForeignKey(e => e.StoreId)
    .IsRequired();
            modelBuilder.Entity<Sale>()
        .Property(b => b.Date)
        .HasDefaultValueSql("getdate()");
        }

    }
}
