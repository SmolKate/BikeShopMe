﻿// <auto-generated />
using System;
using BikeShop.Service.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BikeShop.Service.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230501091601_complacationWork")]
    partial class complacationWork
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BikeShop.Service.Domain.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClientDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("DiscountProduct")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("DiscountWork")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PriceProduct")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PriceWork")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductDiscountId")
                        .HasColumnType("int");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalProduct")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalWork")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserCreatedDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserCreatedId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserDeletedId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserMasterDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("UserMasterId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserUpdatedId")
                        .HasColumnType("char(36)");

                    b.Property<int>("WorkDiscountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientDescription = "desc",
                            ClientId = new Guid("0d708728-2fa2-4733-95f8-2409447c6c9c"),
                            CreatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4407),
                            Discount = 500m,
                            DiscountProduct = 500m,
                            DiscountWork = 500m,
                            Enabled = true,
                            Name = "First",
                            Price = 500m,
                            PriceProduct = 500m,
                            PriceWork = 500m,
                            ProductDiscountId = 0,
                            ShopId = 1,
                            Status = "Waiting",
                            Total = 500m,
                            TotalProduct = 500m,
                            TotalWork = 500m,
                            UpdatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4413),
                            UserCreatedDescription = "desc",
                            UserCreatedId = new Guid("f445be01-05b8-4907-8ecb-3009134b4c93"),
                            UserDeletedId = new Guid("4e60225e-fece-48c0-af00-0a14574758ad"),
                            UserMasterDescription = "desc",
                            UserMasterId = new Guid("2b1148a9-b629-4bbc-8dc7-35a953482600"),
                            UserUpdatedId = new Guid("00000000-0000-0000-0000-000000000000"),
                            WorkDiscountId = 0
                        });
                });

            modelBuilder.Entity("BikeShop.Service.Domain.Entities.ServiceProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CatalogKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("QuantityUnitId")
                        .HasColumnType("int");

                    b.Property<string>("QuantityUnitName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("ServiceProducts");
                });

            modelBuilder.Entity("BikeShop.Service.Domain.Entities.ServiceWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("ComplicationPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ServiceWorks");
                });

            modelBuilder.Entity("BikeShop.Service.Domain.Entities.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("WorkGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkGroupId");

                    b.ToTable("Works");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4328),
                            Description = "Work description 1",
                            Enabled = true,
                            Name = "Work 1",
                            Price = 228.0,
                            UpdatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4342),
                            WorkGroupId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4346),
                            Description = "Work description 2",
                            Enabled = true,
                            Name = "Work 2",
                            Price = 300.0,
                            UpdatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4348),
                            WorkGroupId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4356),
                            Description = "Work description 3",
                            Enabled = true,
                            Name = "Work 3",
                            Price = 500.0,
                            UpdatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4358),
                            WorkGroupId = 2
                        });
                });

            modelBuilder.Entity("BikeShop.Service.Domain.Entities.WorkGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsCollapsed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("ShopId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("WorkGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(3938),
                            Enabled = true,
                            IsCollapsed = true,
                            Name = "First work group",
                            ParentId = 0,
                            ShopId = 1,
                            UpdatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4011)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4016),
                            Enabled = true,
                            IsCollapsed = true,
                            Name = "Second work group",
                            ParentId = 0,
                            ShopId = 1,
                            UpdatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4019)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4022),
                            Enabled = true,
                            IsCollapsed = false,
                            Name = "First Child of first work group",
                            ParentId = 1,
                            ShopId = 1,
                            UpdatedAt = new DateTime(2023, 5, 1, 12, 16, 1, 188, DateTimeKind.Local).AddTicks(4034)
                        });
                });

            modelBuilder.Entity("BikeShop.Service.Domain.Entities.Work", b =>
                {
                    b.HasOne("BikeShop.Service.Domain.Entities.WorkGroup", "WorkGroup")
                        .WithMany()
                        .HasForeignKey("WorkGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkGroup");
                });
#pragma warning restore 612, 618
        }
    }
}