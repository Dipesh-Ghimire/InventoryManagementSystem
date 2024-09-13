﻿// <auto-generated />
using System;
using IMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMS.web.Migrations.IMSDb
{
    [DbContext(typeof(IMSDbContext))]
    partial class IMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IMS.Models.Entity.CategoryInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("StoreInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoreInfoId");

                    b.ToTable("CategoryInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.CustomerInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PanNo")
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("StoreInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoreInfoId");

                    b.ToTable("CustomerInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryInfoId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("StoreInfoId")
                        .HasColumnType("int");

                    b.Property<int>("UnitInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryInfoId");

                    b.HasIndex("StoreInfoId");

                    b.HasIndex("UnitInfoId");

                    b.ToTable("ProductInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductInvoiceDetailInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("ProductInvoiceInfoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductRateInfoId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProductInvoiceInfoId");

                    b.HasIndex("ProductRateInfoId");

                    b.ToTable("ProductInvoiceDetailInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductInvoiceInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BillStatus")
                        .HasColumnType("int");

                    b.Property<string>("CancellationRemarks")
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("CustomerInfoId")
                        .HasColumnType("int");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<string>("InvoiceNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<double>("NetAmount")
                        .HasColumnType("float");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("StoreInfoId")
                        .HasColumnType("int");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CustomerInfoId");

                    b.HasIndex("StoreInfoId");

                    b.ToTable("ProductInvoiceInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductRateInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BatchNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CategoryInfoId")
                        .HasColumnType("int");

                    b.Property<double>("CostPrice")
                        .HasColumnType("float");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("Expirydate")
                        .IsRequired()
                        .HasColumnType("datetime");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("ProductInfoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchasedDate")
                        .HasColumnType("datetime");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("RackInfoId")
                        .HasColumnType("int");

                    b.Property<double>("RemainingQuantity")
                        .HasColumnType("float");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("float");

                    b.Property<double>("SoldQuantity")
                        .HasColumnType("float");

                    b.Property<int>("StoreInfoId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryInfoId");

                    b.HasIndex("ProductInfoId");

                    b.HasIndex("RackInfoId");

                    b.HasIndex("StoreInfoId");

                    b.HasIndex("SupplierInfoId");

                    b.ToTable("ProductRateInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.RackInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("RackName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("StoreInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoreInfoId");

                    b.ToTable("RackInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.StockInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryInfoId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("ProductInfoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductRateInfoId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("StoreInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryInfoId");

                    b.HasIndex("ProductInfoId");

                    b.HasIndex("ProductRateInfoId");

                    b.HasIndex("StoreInfoId");

                    b.ToTable("StockInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.StoreInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("LogoUrl")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PanNo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RegistrationNo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("StoreInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.SupplierInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("StoreInfoId")
                        .HasColumnType("int");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("StoreInfoId");

                    b.ToTable("SupplierInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.TransactionInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CategoryInfoId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<int>("ProductInfoId")
                        .HasColumnType("int");

                    b.Property<int>("ProductRateInfoId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("StoreInfoId")
                        .HasColumnType("int");

                    b.Property<string>("TransactionType")
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("UnitInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryInfoId");

                    b.HasIndex("ProductInfoId");

                    b.HasIndex("ProductRateInfoId");

                    b.HasIndex("StoreInfoId");

                    b.HasIndex("UnitInfoId");

                    b.ToTable("TransactionInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.UnitInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ModifiedBy")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("UnitInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.CategoryInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.StoreInfo", "StoreInfo")
                        .WithMany("CategoryInfos")
                        .HasForeignKey("StoreInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoreInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.CustomerInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.StoreInfo", "StoreInfo")
                        .WithMany("CustomerInfos")
                        .HasForeignKey("StoreInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoreInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.CategoryInfo", "CategoryInfo")
                        .WithMany("ProductInfos")
                        .HasForeignKey("CategoryInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.StoreInfo", "StoreInfo")
                        .WithMany("ProductInfos")
                        .HasForeignKey("StoreInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.UnitInfo", "UnitInfo")
                        .WithMany("ProductInfos")
                        .HasForeignKey("UnitInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryInfo");

                    b.Navigation("StoreInfo");

                    b.Navigation("UnitInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductInvoiceDetailInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.ProductInvoiceInfo", "ProductInvoiceInfo")
                        .WithMany("ProductInvoiceDetailInfos")
                        .HasForeignKey("ProductInvoiceInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.ProductRateInfo", "ProductRateInfo")
                        .WithMany("ProductInvoiceDetailInfos")
                        .HasForeignKey("ProductRateInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductInvoiceInfo");

                    b.Navigation("ProductRateInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductInvoiceInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.CustomerInfo", "CustomerInfo")
                        .WithMany("ProductInvoiceInfos")
                        .HasForeignKey("CustomerInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.StoreInfo", "StoreInfo")
                        .WithMany("ProductInvoiceInfos")
                        .HasForeignKey("StoreInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CustomerInfo");

                    b.Navigation("StoreInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductRateInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.CategoryInfo", "CategoryInfo")
                        .WithMany("ProductRateInfos")
                        .HasForeignKey("CategoryInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.ProductInfo", "ProductInfo")
                        .WithMany("ProductRateInfos")
                        .HasForeignKey("ProductInfoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.RackInfo", "RackInfo")
                        .WithMany("ProductRateInfos")
                        .HasForeignKey("RackInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.StoreInfo", "StoreInfo")
                        .WithMany("ProductRateInfos")
                        .HasForeignKey("StoreInfoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.SupplierInfo", "SupplierInfo")
                        .WithMany("ProductRateInfos")
                        .HasForeignKey("SupplierInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CategoryInfo");

                    b.Navigation("ProductInfo");

                    b.Navigation("RackInfo");

                    b.Navigation("StoreInfo");

                    b.Navigation("SupplierInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.RackInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.StoreInfo", "StoreInfo")
                        .WithMany("RackInfos")
                        .HasForeignKey("StoreInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoreInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.StockInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.CategoryInfo", "CategoryInfo")
                        .WithMany("StockInfos")
                        .HasForeignKey("CategoryInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.ProductInfo", "ProductInfo")
                        .WithMany("StockInfos")
                        .HasForeignKey("ProductInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.ProductRateInfo", "ProductRateInfo")
                        .WithMany("StockInfos")
                        .HasForeignKey("ProductRateInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.StoreInfo", "StoreInfo")
                        .WithMany("StockInfos")
                        .HasForeignKey("StoreInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CategoryInfo");

                    b.Navigation("ProductInfo");

                    b.Navigation("ProductRateInfo");

                    b.Navigation("StoreInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.SupplierInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.StoreInfo", "StoreInfo")
                        .WithMany("SupplierInfos")
                        .HasForeignKey("StoreInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StoreInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.TransactionInfo", b =>
                {
                    b.HasOne("IMS.Models.Entity.CategoryInfo", "CategoryInfo")
                        .WithMany("TransactionInfos")
                        .HasForeignKey("CategoryInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.ProductInfo", "ProductInfo")
                        .WithMany("TransactionInfos")
                        .HasForeignKey("ProductInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.ProductRateInfo", "ProductRateInfo")
                        .WithMany("TransactionInfos")
                        .HasForeignKey("ProductRateInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.StoreInfo", "StoreInfo")
                        .WithMany("TransactionInfos")
                        .HasForeignKey("StoreInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("IMS.Models.Entity.UnitInfo", "UnitInfo")
                        .WithMany("TransactionInfos")
                        .HasForeignKey("UnitInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryInfo");

                    b.Navigation("ProductInfo");

                    b.Navigation("ProductRateInfo");

                    b.Navigation("StoreInfo");

                    b.Navigation("UnitInfo");
                });

            modelBuilder.Entity("IMS.Models.Entity.CategoryInfo", b =>
                {
                    b.Navigation("ProductInfos");

                    b.Navigation("ProductRateInfos");

                    b.Navigation("StockInfos");

                    b.Navigation("TransactionInfos");
                });

            modelBuilder.Entity("IMS.Models.Entity.CustomerInfo", b =>
                {
                    b.Navigation("ProductInvoiceInfos");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductInfo", b =>
                {
                    b.Navigation("ProductRateInfos");

                    b.Navigation("StockInfos");

                    b.Navigation("TransactionInfos");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductInvoiceInfo", b =>
                {
                    b.Navigation("ProductInvoiceDetailInfos");
                });

            modelBuilder.Entity("IMS.Models.Entity.ProductRateInfo", b =>
                {
                    b.Navigation("ProductInvoiceDetailInfos");

                    b.Navigation("StockInfos");

                    b.Navigation("TransactionInfos");
                });

            modelBuilder.Entity("IMS.Models.Entity.RackInfo", b =>
                {
                    b.Navigation("ProductRateInfos");
                });

            modelBuilder.Entity("IMS.Models.Entity.StoreInfo", b =>
                {
                    b.Navigation("CategoryInfos");

                    b.Navigation("CustomerInfos");

                    b.Navigation("ProductInfos");

                    b.Navigation("ProductInvoiceInfos");

                    b.Navigation("ProductRateInfos");

                    b.Navigation("RackInfos");

                    b.Navigation("StockInfos");

                    b.Navigation("SupplierInfos");

                    b.Navigation("TransactionInfos");
                });

            modelBuilder.Entity("IMS.Models.Entity.SupplierInfo", b =>
                {
                    b.Navigation("ProductRateInfos");
                });

            modelBuilder.Entity("IMS.Models.Entity.UnitInfo", b =>
                {
                    b.Navigation("ProductInfos");

                    b.Navigation("TransactionInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
