﻿// <auto-generated />
using System;
using Commands.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Commands.Infrastructure.Migrations
{
    [DbContext(typeof(SQLContext))]
    [Migration("20241013062506_AddFKProductId")]
    partial class AddFKProductId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Commands.Infrastructure.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Article")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Condition")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceWithDiscount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8810a1a6-139a-8e2a-8475-0192848d4dd2"),
                            Article = "1",
                            Condition = 1,
                            Description = "Product 1",
                            Name = "Product 1",
                            Price = 10.99m,
                            PriceWithDiscount = 8m
                        },
                        new
                        {
                            Id = new Guid("225eb740-008d-88de-8476-0192848d4dd2"),
                            Article = "2",
                            Condition = 1,
                            Description = "Product 2",
                            Name = "Product 2",
                            Price = 10.99m,
                            PriceWithDiscount = 10m
                        },
                        new
                        {
                            Id = new Guid("b1fde725-e962-8988-8477-0192848d4dd2"),
                            Article = "3",
                            Condition = 1,
                            Description = "Product 3",
                            Name = "Product 3",
                            Price = 20m,
                            PriceWithDiscount = 11m
                        },
                        new
                        {
                            Id = new Guid("6d901439-6ff5-8aa0-8478-0192848d4dd2"),
                            Article = "4",
                            Condition = 1,
                            Description = "Product 4",
                            Name = "Product 4",
                            Price = 22m,
                            PriceWithDiscount = 10m
                        },
                        new
                        {
                            Id = new Guid("a3d6ef45-ad04-832b-8479-0192848d4dd2"),
                            Article = "5",
                            Condition = 1,
                            Description = "Product 5",
                            Name = "Product 5",
                            Price = 60m,
                            PriceWithDiscount = 11m
                        },
                        new
                        {
                            Id = new Guid("4ac7e658-00e8-86d0-847a-0192848d4dd2"),
                            Article = "6",
                            Condition = 1,
                            Description = "Product 6",
                            Name = "Product 6",
                            Price = 55m,
                            PriceWithDiscount = 10m
                        },
                        new
                        {
                            Id = new Guid("39956ed2-fa41-83c2-847b-0192848d4dd2"),
                            Article = "7",
                            Condition = 1,
                            Description = "Product 7",
                            Name = "Product 7",
                            Price = 44m,
                            PriceWithDiscount = 14m
                        },
                        new
                        {
                            Id = new Guid("15ea94a7-7407-8f1e-847c-0192848d4dd2"),
                            Article = "8",
                            Condition = 1,
                            Description = "Product 8",
                            Name = "Product 8",
                            Price = 10.99m,
                            PriceWithDiscount = 10m
                        },
                        new
                        {
                            Id = new Guid("69f5d911-fdc8-8b71-847d-0192848d4dd2"),
                            Article = "9",
                            Condition = 1,
                            Description = "Product 9",
                            Name = "Product 9",
                            Price = 13m,
                            PriceWithDiscount = 10m
                        },
                        new
                        {
                            Id = new Guid("83f521c5-227b-803c-847e-0192848d4dd2"),
                            Article = "10",
                            Condition = 1,
                            Description = "Product 10",
                            Name = "Product 10",
                            Price = 17m,
                            PriceWithDiscount = 10m
                        },
                        new
                        {
                            Id = new Guid("3c9608cf-afbd-8a9f-847f-0192848d4dd2"),
                            Article = "11",
                            Condition = 1,
                            Description = "Product 11",
                            Name = "Product 11",
                            Price = 19m,
                            PriceWithDiscount = 10m
                        },
                        new
                        {
                            Id = new Guid("e7dcc86b-6422-8ead-8480-0192848d4dd2"),
                            Article = "12",
                            Condition = 1,
                            Description = "Product 12",
                            Name = "Product 12",
                            Price = 14m,
                            PriceWithDiscount = 10m
                        },
                        new
                        {
                            Id = new Guid("4cfcf332-2464-8d3d-8481-0192848d4dd2"),
                            Article = "12",
                            Condition = 1,
                            Description = "Product 13",
                            Name = "Product 13",
                            Price = 25m,
                            PriceWithDiscount = 10m
                        });
                });

            modelBuilder.Entity("Commands.Infrastructure.Entities.ProductImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Commands.Infrastructure.Entities.ProductImage", b =>
                {
                    b.HasOne("Commands.Infrastructure.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
