﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PDP104.Data;

#nullable disable

namespace PDP104.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250401105704_Create_seedsdata_services")]
    partial class Create_seedsdata_services
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PDP104.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("InventoryStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StorageOrdersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("PDP104.Models.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("PDP104.Models.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameServices")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StatusService")
                        .HasColumnType("int");

                    b.Property<int>("TypeService")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Dịch vụ lưu trữ hàng balet theo ngày",
                            NameServices = "Lưu trữ hàng Balet - Ngày",
                            StatusService = 0,
                            TypeService = 0,
                            UnitPrice = 100000m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dịch vụ lưu trữ hàng balet theo tháng",
                            NameServices = "Lưu trữ hàng Balet - Tháng",
                            StatusService = 0,
                            TypeService = 0,
                            UnitPrice = 1500000m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dịch vụ lưu trữ hàng balet theo năm",
                            NameServices = "Lưu trữ hàng Balet - Năm",
                            StatusService = 0,
                            TypeService = 0,
                            UnitPrice = 5000000m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Dịch vụ lưu trữ Container 18ft theo ngày",
                            NameServices = "Lưu trữ Container 18ft - Ngày",
                            StatusService = 0,
                            TypeService = 1,
                            UnitPrice = 200000m
                        },
                        new
                        {
                            Id = 5,
                            Description = "Dịch vụ lưu trữ Container 18ft theo tháng",
                            NameServices = "Lưu trữ Container 18ft - Tháng",
                            StatusService = 0,
                            TypeService = 1,
                            UnitPrice = 1500000m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Dịch vụ lưu trữ Container 18ft theo năm",
                            NameServices = "Lưu trữ Container 18ft - Năm",
                            StatusService = 0,
                            TypeService = 1,
                            UnitPrice = 15000000m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Dịch vụ lưu trữ Container 20ft theo ngày",
                            NameServices = "Lưu trữ Container 20ft - Ngày",
                            StatusService = 0,
                            TypeService = 2,
                            UnitPrice = 250000m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Dịch vụ lưu trữ Container 20ft theo tháng",
                            NameServices = "Lưu trữ Container 20ft - Tháng",
                            StatusService = 0,
                            TypeService = 2,
                            UnitPrice = 2000000m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Dịch vụ lưu trữ Container 20ft theo năm",
                            NameServices = "Lưu trữ Container 20ft - Năm",
                            StatusService = 0,
                            TypeService = 2,
                            UnitPrice = 20000000m
                        },
                        new
                        {
                            Id = 10,
                            Description = "Dịch vụ lưu trữ Container 22ft theo ngày",
                            NameServices = "Lưu trữ Container 22ft - Ngày",
                            StatusService = 0,
                            TypeService = 3,
                            UnitPrice = 300000m
                        },
                        new
                        {
                            Id = 11,
                            Description = "Dịch vụ lưu trữ Container 22ft theo tháng",
                            NameServices = "Lưu trữ Container 22ft - Tháng",
                            StatusService = 0,
                            TypeService = 3,
                            UnitPrice = 2500000m
                        },
                        new
                        {
                            Id = 12,
                            Description = "Dịch vụ lưu trữ Container 22ft theo năm",
                            NameServices = "Lưu trữ Container 22ft - Năm",
                            StatusService = 0,
                            TypeService = 3,
                            UnitPrice = 25000000m
                        });
                });

            modelBuilder.Entity("PDP104.Models.StorageOrderServices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ServicesId")
                        .HasColumnType("int");

                    b.Property<int>("StorageOrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServicesId");

                    b.HasIndex("StorageOrderId");

                    b.ToTable("StorageOrderServices");
                });

            modelBuilder.Entity("PDP104.Models.StorageOrders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfEntry")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfShipment")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hinh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("NguoiDungId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StatusInventory")
                        .HasColumnType("int");

                    b.Property<int>("StatusOrder")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfGoods")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId")
                        .IsUnique()
                        .HasFilter("[InventoryId] IS NOT NULL");

                    b.HasIndex("NguoiDungId");

                    b.ToTable("StorageOrders");
                });

            modelBuilder.Entity("PDP104.Models.StorageSpaces", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("LocationStorage")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("StorageOrdersId")
                        .HasColumnType("int");

                    b.Property<int>("WareHouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StorageOrdersId");

                    b.HasIndex("WareHouseId");

                    b.ToTable("StorageSpaces");
                });

            modelBuilder.Entity("PDP104.Models.WareHouses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WareHouses");
                });

            modelBuilder.Entity("PDP104.Models.NguoiDung", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Hinh")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("NameND")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasDiscriminator().HasValue("NguoiDung");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PDP104.Models.InventoryItem", b =>
                {
                    b.HasOne("PDP104.Models.Inventory", "Inventory")
                        .WithMany("inventoryItems")
                        .HasForeignKey("InventoryId");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("PDP104.Models.StorageOrderServices", b =>
                {
                    b.HasOne("PDP104.Models.Services", "Services")
                        .WithMany("StorageOrderServices")
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PDP104.Models.StorageOrders", "StorageOrder")
                        .WithMany("StorageOrderServices")
                        .HasForeignKey("StorageOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Services");

                    b.Navigation("StorageOrder");
                });

            modelBuilder.Entity("PDP104.Models.StorageOrders", b =>
                {
                    b.HasOne("PDP104.Models.Inventory", "Inventory")
                        .WithOne("StorageOrders")
                        .HasForeignKey("PDP104.Models.StorageOrders", "InventoryId");

                    b.HasOne("PDP104.Models.NguoiDung", "NguoiDung")
                        .WithMany("StorageOrders")
                        .HasForeignKey("NguoiDungId");

                    b.Navigation("Inventory");

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("PDP104.Models.StorageSpaces", b =>
                {
                    b.HasOne("PDP104.Models.StorageOrders", "StorageOrders")
                        .WithMany("StorageSpaces")
                        .HasForeignKey("StorageOrdersId");

                    b.HasOne("PDP104.Models.WareHouses", "WareHouse")
                        .WithMany("StorageSpaces")
                        .HasForeignKey("WareHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StorageOrders");

                    b.Navigation("WareHouse");
                });

            modelBuilder.Entity("PDP104.Models.Inventory", b =>
                {
                    b.Navigation("StorageOrders");

                    b.Navigation("inventoryItems");
                });

            modelBuilder.Entity("PDP104.Models.Services", b =>
                {
                    b.Navigation("StorageOrderServices");
                });

            modelBuilder.Entity("PDP104.Models.StorageOrders", b =>
                {
                    b.Navigation("StorageOrderServices");

                    b.Navigation("StorageSpaces");
                });

            modelBuilder.Entity("PDP104.Models.WareHouses", b =>
                {
                    b.Navigation("StorageSpaces");
                });

            modelBuilder.Entity("PDP104.Models.NguoiDung", b =>
                {
                    b.Navigation("StorageOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
