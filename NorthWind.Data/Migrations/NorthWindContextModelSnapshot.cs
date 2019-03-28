﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NorthWind.Data;

namespace NorthWind.Data.Migrations
{
    [DbContext(typeof(NorthWindContext))]
    partial class NorthWindContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NorthWind.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Description");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("NorthWind.Entities.Log", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("Getdate()");

                    b.Property<string>("Message");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("LogID");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("NorthWind.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<decimal?>("UnitPrice");

                    b.Property<int>("UnitsInStock");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("NorthWind.Entities.Product", b =>
                {
                    b.HasOne("NorthWind.Entities.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
