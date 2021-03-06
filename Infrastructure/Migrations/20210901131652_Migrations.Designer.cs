// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20210901131652_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductBrandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c2e3f61d-7aef-46bd-aa93-5edf0296bcaa"),
                            Description = "Product 1",
                            Name = "Product 1",
                            PictureUrl = "images/products/p1.png",
                            Price = 200m,
                            ProductBrandId = new Guid("b681c1e2-9474-4898-b44a-c51a89641793"),
                            ProductTypeId = new Guid("2613691f-f308-4d69-be42-a139b7b4de5b")
                        });
                });

            modelBuilder.Entity("Core.Entity.ProductBrand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductBrand");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b681c1e2-9474-4898-b44a-c51a89641793"),
                            Name = "Grand 1"
                        },
                        new
                        {
                            Id = new Guid("55e5b93a-f74b-4f39-b9c9-6be874cdd716"),
                            Name = "Grand 2"
                        },
                        new
                        {
                            Id = new Guid("9028007b-adb2-4fb9-84e5-f017ad1f1dab"),
                            Name = "Grand 3"
                        },
                        new
                        {
                            Id = new Guid("695cd6e0-5db8-4bc2-8b6d-b93a6511d373"),
                            Name = "Grand 4"
                        });
                });

            modelBuilder.Entity("Core.Entity.ProductType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2613691f-f308-4d69-be42-a139b7b4de5b"),
                            Name = "Type 1"
                        },
                        new
                        {
                            Id = new Guid("e2bd7957-3ec2-4d0b-851e-bb7ff68c8dff"),
                            Name = "Type 2"
                        },
                        new
                        {
                            Id = new Guid("9a810ff8-d1e1-43d8-a5f6-f8b9596069da"),
                            Name = "Type 3"
                        },
                        new
                        {
                            Id = new Guid("f631b751-3c8b-4f3a-8bf7-f4e88571b80b"),
                            Name = "Type 4"
                        });
                });

            modelBuilder.Entity("Core.Entity.Product", b =>
                {
                    b.HasOne("Core.Entity.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entity.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductType");
                });
#pragma warning restore 612, 618
        }
    }
}
