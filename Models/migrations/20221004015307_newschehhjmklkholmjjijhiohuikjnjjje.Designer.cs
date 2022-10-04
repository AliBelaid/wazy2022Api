﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wazyApi.Models;

#nullable disable

namespace wazyApi.Models.migrations
{
    [DbContext(typeof(wazytools_vendorContext))]
    [Migration("20221004015307_newschehhjmklkholmjjijhiohuikjnjjje")]
    partial class newschehhjmklkholmjjijhiohuikjnjjje
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("wazyApi.Models.Blog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("author")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("slug")
                        .HasColumnType("longtext");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("wazyApi.Models.BlogCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Blogid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("slug")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Blogid");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("wazyApi.Models.Brand", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Productid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("slug")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Productid");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("wazyApi.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Productid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("slug")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Productid");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("wazyApi.Models.Picture", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Productid")
                        .HasColumnType("int");

                    b.Property<string>("height")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("width")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Productid");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("wazyApi.Models.Pivot", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BlogCategoryId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductCategoryId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("blog_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("brand_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("product_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("related_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("upload_file_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Pivots");
                });

            modelBuilder.Entity("wazyApi.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("longtext");

                    b.Property<int>("AvQty")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<bool?>("Featured")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("HasComment")
                        .HasColumnType("longtext");

                    b.Property<int>("IsNew")
                        .HasColumnType("int");

                    b.Property<int>("IsSale")
                        .HasColumnType("int");

                    b.Property<string>("LongDesc")
                        .HasColumnType("longtext");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("New")
                        .HasColumnType("int");

                    b.Property<string>("OnlineStatus")
                        .HasColumnType("longtext");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("RefField")
                        .HasColumnType("longtext");

                    b.Property<int?>("Reviews")
                        .HasColumnType("int");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("longtext");

                    b.Property<bool?>("Sold")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("Top")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Until")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("VendorId")
                        .HasColumnType("int");

                    b.Property<string>("slug")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("wazyApi.Models.Size", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Variantid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("slug")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Variantid");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("wazyApi.Models.SmPicture", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Productid")
                        .HasColumnType("int");

                    b.Property<string>("height")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("width")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("Productid");

                    b.ToTable("SmPictures");
                });

            modelBuilder.Entity("wazyApi.Models.Variant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Productid")
                        .HasColumnType("int");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("color_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("price")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.HasIndex("Productid");

                    b.ToTable("Variants");
                });

            modelBuilder.Entity("wazyApi.Models.BlogCategory", b =>
                {
                    b.HasOne("wazyApi.Models.Blog", null)
                        .WithMany("blog_categories")
                        .HasForeignKey("Blogid");
                });

            modelBuilder.Entity("wazyApi.Models.Brand", b =>
                {
                    b.HasOne("wazyApi.Models.Product", null)
                        .WithMany("brands")
                        .HasForeignKey("Productid");
                });

            modelBuilder.Entity("wazyApi.Models.Category", b =>
                {
                    b.HasOne("wazyApi.Models.Product", null)
                        .WithMany("category")
                        .HasForeignKey("Productid");
                });

            modelBuilder.Entity("wazyApi.Models.Picture", b =>
                {
                    b.HasOne("wazyApi.Models.Product", null)
                        .WithMany("pictures")
                        .HasForeignKey("Productid");
                });

            modelBuilder.Entity("wazyApi.Models.Size", b =>
                {
                    b.HasOne("wazyApi.Models.Variant", null)
                        .WithMany("size")
                        .HasForeignKey("Variantid");
                });

            modelBuilder.Entity("wazyApi.Models.SmPicture", b =>
                {
                    b.HasOne("wazyApi.Models.Product", null)
                        .WithMany("sm_pictures")
                        .HasForeignKey("Productid");
                });

            modelBuilder.Entity("wazyApi.Models.Variant", b =>
                {
                    b.HasOne("wazyApi.Models.Product", null)
                        .WithMany("variants")
                        .HasForeignKey("Productid");
                });

            modelBuilder.Entity("wazyApi.Models.Blog", b =>
                {
                    b.Navigation("blog_categories");
                });

            modelBuilder.Entity("wazyApi.Models.Product", b =>
                {
                    b.Navigation("brands");

                    b.Navigation("category");

                    b.Navigation("pictures");

                    b.Navigation("sm_pictures");

                    b.Navigation("variants");
                });

            modelBuilder.Entity("wazyApi.Models.Variant", b =>
                {
                    b.Navigation("size");
                });
#pragma warning restore 612, 618
        }
    }
}
