﻿// <auto-generated />
using System;
using EP_Jewellery.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EP_Jewellery.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230918041632_Diep")]
    partial class Diep
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EP_Jewellery.Models.Admin", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("username");

                    b.ToTable("AdminLoginMst");
                });

            modelBuilder.Entity("EP_Jewellery.Models.BrandMst", b =>
                {
                    b.Property<string>("Brand_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Brand_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Brand_ID");

                    b.ToTable("BrandMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.CardMst", b =>
                {
                    b.Property<string>("Cat_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Cat_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Cat_ID");

                    b.ToTable("CardMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.CertifyMst", b =>
                {
                    b.Property<string>("Certify_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Certify_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Certify_ID");

                    b.ToTable("CertifyMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.DimInfoMst", b =>
                {
                    b.Property<string>("DimID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimCrt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimImg")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimPrice")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimSubType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DimType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DimID");

                    b.ToTable("DimInfoMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.DimMst", b =>
                {
                    b.Property<int>("DimMst_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DimMst_ID"));

                    b.Property<string>("DimInfoMstDimID")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimQlty_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimSubType_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Dim_Amt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Crt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Gm")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Pcs")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Rate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Dim_Size")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Style_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DimMst_ID");

                    b.HasIndex("DimInfoMstDimID");

                    b.HasIndex("DimQlty_ID");

                    b.HasIndex("DimSubType_ID");

                    b.HasIndex("Style_Code");

                    b.ToTable("DimMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.DimQltyMst", b =>
                {
                    b.Property<string>("DimQlty_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimQlty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DimQlty_ID");

                    b.ToTable("DimQtyMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.DimQltySubMst", b =>
                {
                    b.Property<string>("DimSubType_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DimQlty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DimSubType_ID");

                    b.ToTable("DimQltySubMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.GoldKrtMst", b =>
                {
                    b.Property<string>("GoldType_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Gold_Crt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GoldType_ID");

                    b.ToTable("GoldKrtMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.ItemMst", b =>
                {
                    b.Property<string>("Style_Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Brand_ID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CardMstCat_ID")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Certify_ID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("GoldType_ID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Gold_Amt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Gold_Making")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Gold_Rate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Gold_Wt")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("MRP")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Net_Gold")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("Other_Making")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Prod_ID")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Prod_Quality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Stone_Making")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stone_Wt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Tot_Gross_Wt")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("Tot_Making")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Wstg")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("Wstg_Per")
                        .HasColumnType("decimal(10,3)");

                    b.HasKey("Style_Code");

                    b.HasIndex("Brand_ID");

                    b.HasIndex("CardMstCat_ID");

                    b.HasIndex("Certify_ID");

                    b.HasIndex("GoldType_ID");

                    b.HasIndex("Prod_ID");

                    b.ToTable("ItemMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.JewelTypeMst", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Jewellery_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("JewelTypeMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.ProdMst", b =>
                {
                    b.Property<string>("Prod_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Prod_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Prod_ID");

                    b.ToTable("ProdMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.StoneMst", b =>
                {
                    b.Property<int>("StoneMst_ID")
                        .HasColumnType("int");

                    b.Property<string>("StoneQlty_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Stone_Amt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stone_Crt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stone_Gm")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stone_Pcs")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Stone_Rate")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Style_Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StoneMst_ID");

                    b.HasIndex("StoneQlty_ID");

                    b.HasIndex("Style_Code");

                    b.ToTable("StoneMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.StoneQltyMst", b =>
                {
                    b.Property<string>("StoneQlty_ID")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("StoneQlty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StoneQlty_ID");

                    b.ToTable("StoneQltyMsts");
                });

            modelBuilder.Entity("EP_Jewellery.Models.User", b =>
                {
                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("cdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("emailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("mobNo")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userFName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userLName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("UserRegMst");
                });

            modelBuilder.Entity("EP_Jewellery.Models.DimMst", b =>
                {
                    b.HasOne("EP_Jewellery.Models.DimInfoMst", null)
                        .WithMany("DimDiamonds")
                        .HasForeignKey("DimInfoMstDimID");

                    b.HasOne("EP_Jewellery.Models.DimQltyMst", "DiamondQuality")
                        .WithMany("DimDiamonds")
                        .HasForeignKey("DimQlty_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_Jewellery.Models.DimQltySubMst", "DimQualitySubType")
                        .WithMany("DimDiamonds")
                        .HasForeignKey("DimSubType_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_Jewellery.Models.ItemMst", "Stone")
                        .WithMany()
                        .HasForeignKey("Style_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiamondQuality");

                    b.Navigation("DimQualitySubType");

                    b.Navigation("Stone");
                });

            modelBuilder.Entity("EP_Jewellery.Models.ItemMst", b =>
                {
                    b.HasOne("EP_Jewellery.Models.BrandMst", "Brand")
                        .WithMany("Items")
                        .HasForeignKey("Brand_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_Jewellery.Models.CardMst", null)
                        .WithMany("Items")
                        .HasForeignKey("CardMstCat_ID");

                    b.HasOne("EP_Jewellery.Models.CertifyMst", "Certify")
                        .WithMany("Items")
                        .HasForeignKey("Certify_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_Jewellery.Models.GoldKrtMst", "GoldKrt")
                        .WithMany("Items")
                        .HasForeignKey("GoldType_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_Jewellery.Models.ProdMst", "Prod")
                        .WithMany("Items")
                        .HasForeignKey("Prod_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Certify");

                    b.Navigation("GoldKrt");

                    b.Navigation("Prod");
                });

            modelBuilder.Entity("EP_Jewellery.Models.StoneMst", b =>
                {
                    b.HasOne("EP_Jewellery.Models.StoneQltyMst", "StoneQuality")
                        .WithMany("Stones")
                        .HasForeignKey("StoneQlty_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_Jewellery.Models.ItemMst", "Item")
                        .WithMany("Stones")
                        .HasForeignKey("Style_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("StoneQuality");
                });

            modelBuilder.Entity("EP_Jewellery.Models.BrandMst", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("EP_Jewellery.Models.CardMst", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("EP_Jewellery.Models.CertifyMst", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("EP_Jewellery.Models.DimInfoMst", b =>
                {
                    b.Navigation("DimDiamonds");
                });

            modelBuilder.Entity("EP_Jewellery.Models.DimQltyMst", b =>
                {
                    b.Navigation("DimDiamonds");
                });

            modelBuilder.Entity("EP_Jewellery.Models.DimQltySubMst", b =>
                {
                    b.Navigation("DimDiamonds");
                });

            modelBuilder.Entity("EP_Jewellery.Models.GoldKrtMst", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("EP_Jewellery.Models.ItemMst", b =>
                {
                    b.Navigation("Stones");
                });

            modelBuilder.Entity("EP_Jewellery.Models.ProdMst", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("EP_Jewellery.Models.StoneQltyMst", b =>
                {
                    b.Navigation("Stones");
                });
#pragma warning restore 612, 618
        }
    }
}
