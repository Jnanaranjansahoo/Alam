﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Stock.DataAcess.Data;

#nullable disable

namespace Stock.DataAcess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Stock.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action",
                            Quantity = 0.0
                        },
                        new
                        {
                            Id = 2,
                            Name = "SciFi",
                            Quantity = 0.0
                        },
                        new
                        {
                            Id = 3,
                            Name = "History",
                            Quantity = 0.0
                        });
                });

            modelBuilder.Entity("Stock.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "it is a good pen",
                            ImageUrl = "",
                            Name = "Pen",
                            Price = 50m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "it is a good pen",
                            ImageUrl = "",
                            Name = "Pensil",
                            Price = 50m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "it is a good pen",
                            ImageUrl = "",
                            Name = "Pepshi",
                            Price = 50m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "it is a good pen",
                            ImageUrl = "",
                            Name = "banana",
                            Price = 50m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "it is a good pen",
                            ImageUrl = "",
                            Name = "mango",
                            Price = 50m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "it is a good pen",
                            ImageUrl = "",
                            Name = "applr",
                            Price = 50m
                        });
                });

            modelBuilder.Entity("Stock.Models.Product", b =>
                {
                    b.HasOne("Stock.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
