﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Product.DAL.Data;

#nullable disable

namespace Product.DAL.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    partial class ProductDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductEntity.Models.Article", b =>
                {
                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ArticleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArticleId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ProductEntity.Models.Colour", b =>
                {
                    b.Property<Guid>("colourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("colourCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("colourName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("colourId");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("ProductEntity.Models.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductYear")
                        .HasColumnType("int");

                    b.Property<Guid>("sizeScaleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProductEntity.Models.SizeScale", b =>
                {
                    b.Property<Guid>("sizeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("sizeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sizeId");

                    b.ToTable("SizeScale");
                });

            modelBuilder.Entity("ProductEntity.Models.Article", b =>
                {
                    b.HasOne("ProductEntity.Models.Colour", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductEntity.Models.Product", "Product")
                        .WithMany("articles")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductEntity.Models.SizeScale", "SizeScale")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");

                    b.Navigation("SizeScale");
                });

            modelBuilder.Entity("ProductEntity.Models.Product", b =>
                {
                    b.Navigation("articles");
                });
#pragma warning restore 612, 618
        }
    }
}