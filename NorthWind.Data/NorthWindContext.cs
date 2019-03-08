using System;
using System.Collections.Generic;
using System.Text;
using NorthWind.Entities;
using NorthWind.Helpers;
using Microsoft;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;


namespace NorthWind.Data
{
    public class NorthWindContext:DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Log> Log { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            var connectionString = HelperConfiguration.GetAppConfiguration().ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(a => a.CategoryName)
                .HasMaxLength(15)
                .IsRequired();

            modelBuilder.Entity<Product>()
               .Property(a => a.ProductName)
               .HasMaxLength(40)
               .IsRequired();

            modelBuilder.Entity<Log>(
                l=> {
                    l.Property(a => a.DateTime)
                    .HasDefaultValueSql("Getdate()");
                    l.Property(a => a.Type)
                    .HasConversion(new EnumToStringConverter<LogType>())
                    .HasMaxLength(20);

                }
                );

        }
    }
}
