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
    [Migration("20230426092009_userUpdate")]
    partial class userUpdate
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
                            ClientId = new Guid("23998046-18e1-4126-851d-c53a07234108"),
                            CreatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4658),
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
                            UpdatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4662),
                            UserCreatedDescription = "desc",
                            UserCreatedId = new Guid("1e36f5d6-8974-47bb-b467-aecc55231876"),
                            UserDeletedId = new Guid("8414ab3e-6383-4d16-9df4-882c4b19cd30"),
                            UserMasterDescription = "desc",
                            UserMasterId = new Guid("dbedd8a3-4beb-44c1-8d82-bae478211ad3"),
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
                            CreatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4602),
                            Description = "Work description 1",
                            Enabled = true,
                            Name = "Work 1",
                            Price = 228.0,
                            UpdatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4610),
                            WorkGroupId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4614),
                            Description = "Work description 2",
                            Enabled = true,
                            Name = "Work 2",
                            Price = 300.0,
                            UpdatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4616),
                            WorkGroupId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4619),
                            Description = "Work description 3",
                            Enabled = true,
                            Name = "Work 3",
                            Price = 500.0,
                            UpdatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4620),
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
                            CreatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4210),
                            Enabled = true,
                            IsCollapsed = true,
                            Name = "First work group",
                            ParentId = 0,
                            ShopId = 1,
                            UpdatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4263)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4268),
                            Enabled = true,
                            IsCollapsed = true,
                            Name = "Second work group",
                            ParentId = 0,
                            ShopId = 1,
                            UpdatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4269)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4272),
                            Enabled = true,
                            IsCollapsed = false,
                            Name = "First Child of first work group",
                            ParentId = 1,
                            ShopId = 1,
                            UpdatedAt = new DateTime(2023, 4, 26, 12, 20, 9, 679, DateTimeKind.Local).AddTicks(4273)
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
