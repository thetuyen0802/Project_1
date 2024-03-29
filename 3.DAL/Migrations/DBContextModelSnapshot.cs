﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _3.DAL.Context;

#nullable disable

namespace _3.DAL.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_3.DAL.Model.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillId"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2024, 3, 28, 1, 44, 47, 822, DateTimeKind.Local).AddTicks(9296));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("EmployessId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymenDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("BillId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployessId");

                    b.ToTable("Bills", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Bill_ProductDetail", b =>
                {
                    b.Property<int?>("ProDetailId")
                        .HasColumnType("int");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.HasKey("ProDetailId", "BillId");

                    b.HasIndex("BillId");

                    b.ToTable("Bill_ProductDetail", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"), 1L, 1);

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Employess", b =>
                {
                    b.Property<int>("EmployessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployessId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("EmployessId");

                    b.HasIndex("UserId");

                    b.ToTable("Employesses", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"), 1L, 1);

                    b.Property<DateTime>("DayEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DayStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Decription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventFormat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("Events", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Event_Product", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("Even_Products", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"), 1L, 1);

                    b.Property<string>("ImageLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.ToTable("Images", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialId"), 1L, 1);

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialId");

                    b.ToTable("Materials", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityExists")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.ProductDetail", b =>
                {
                    b.Property<int>("ProDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProDetailId"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("ProDetailId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ImageId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductDetails", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeId"), 1L, 1);

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeId");

                    b.ToTable("Sizes", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("_3.DAL.Model.Bill", b =>
                {
                    b.HasOne("_3.DAL.Model.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3.DAL.Model.Employess", "Employess")
                        .WithMany("Bills")
                        .HasForeignKey("EmployessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employess");
                });

            modelBuilder.Entity("_3.DAL.Model.Bill_ProductDetail", b =>
                {
                    b.HasOne("_3.DAL.Model.Bill", "Bill")
                        .WithMany("Bill_ProductDetails")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3.DAL.Model.ProductDetail", "ProductDetail")
                        .WithMany("Bill_ProductDetail")
                        .HasForeignKey("ProDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("_3.DAL.Model.Employess", b =>
                {
                    b.HasOne("_3.DAL.Model.User", "User")
                        .WithMany("Employesses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("_3.DAL.Model.Event_Product", b =>
                {
                    b.HasOne("_3.DAL.Model.Event", "Event")
                        .WithMany("Event_Products")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3.DAL.Model.Product", "Product")
                        .WithMany("Event_Products")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("_3.DAL.Model.ProductDetail", b =>
                {
                    b.HasOne("_3.DAL.Model.Brand", "Brand")
                        .WithMany("ProductDetails")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3.DAL.Model.Category", "Category")
                        .WithMany("ProductDetails")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3.DAL.Model.Color", "Color")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3.DAL.Model.Image", "Image")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3.DAL.Model.Material", "Material")
                        .WithMany("ProductDetails")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3.DAL.Model.Product", "Product")
                        .WithMany("ProductDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_3.DAL.Model.Size", "Size")
                        .WithMany("ProductDetails")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Image");

                    b.Navigation("Material");

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("_3.DAL.Model.User", b =>
                {
                    b.HasOne("_3.DAL.Model.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("_3.DAL.Model.Bill", b =>
                {
                    b.Navigation("Bill_ProductDetails");
                });

            modelBuilder.Entity("_3.DAL.Model.Brand", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("_3.DAL.Model.Category", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("_3.DAL.Model.Color", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("_3.DAL.Model.Customer", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("_3.DAL.Model.Employess", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("_3.DAL.Model.Event", b =>
                {
                    b.Navigation("Event_Products");
                });

            modelBuilder.Entity("_3.DAL.Model.Image", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("_3.DAL.Model.Material", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("_3.DAL.Model.Product", b =>
                {
                    b.Navigation("Event_Products");

                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("_3.DAL.Model.ProductDetail", b =>
                {
                    b.Navigation("Bill_ProductDetail");
                });

            modelBuilder.Entity("_3.DAL.Model.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("_3.DAL.Model.Size", b =>
                {
                    b.Navigation("ProductDetails");
                });

            modelBuilder.Entity("_3.DAL.Model.User", b =>
                {
                    b.Navigation("Employesses");
                });
#pragma warning restore 612, 618
        }
    }
}
