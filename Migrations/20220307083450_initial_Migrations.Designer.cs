﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotificationSchedulingAPI.Data;

namespace NotificationSchedulingAPI.Migrations
{
    [DbContext(typeof(NotificationDBContext))]
    [Migration("20220307083450_initial_Migrations")]
    partial class initial_Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NotificationSchedulingAPI.Market", b =>
                {
                    b.Property<int>("MarketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MarketName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarketId");

                    b.ToTable("Markets");

                    b.HasData(
                        new
                        {
                            MarketId = 1,
                            MarketName = "Denmark"
                        },
                        new
                        {
                            MarketId = 2,
                            MarketName = "Norway"
                        },
                        new
                        {
                            MarketId = 3,
                            MarketName = "Sweden"
                        },
                        new
                        {
                            MarketId = 4,
                            MarketName = "FinLand"
                        });
                });

            modelBuilder.Entity("NotificationSchedulingAPI.Models.Company", b =>
                {
                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyNumber")
                        .HasColumnType("int");

                    b.Property<int>("CompanyTypeId")
                        .HasColumnType("int");

                    b.Property<int>("MarketId")
                        .HasColumnType("int");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853b",
                            CompanyName = "Company1",
                            CompanyNumber = 2022030601,
                            CompanyTypeId = 1,
                            MarketId = 1
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853c",
                            CompanyName = "Company2",
                            CompanyNumber = 2022030602,
                            CompanyTypeId = 1,
                            MarketId = 1
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853d",
                            CompanyName = "Company3",
                            CompanyNumber = 2022030603,
                            CompanyTypeId = 2,
                            MarketId = 2
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853e",
                            CompanyName = "Company4",
                            CompanyNumber = 2022030604,
                            CompanyTypeId = 2,
                            MarketId = 2
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853f",
                            CompanyName = "Company5",
                            CompanyNumber = 2022030605,
                            CompanyTypeId = 3,
                            MarketId = 3
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b84785g",
                            CompanyName = "Company6",
                            CompanyNumber = 2022030606,
                            CompanyTypeId = 3,
                            MarketId = 3
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853h",
                            CompanyName = "Company7",
                            CompanyNumber = 2022030607,
                            CompanyTypeId = 3,
                            MarketId = 4
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853i",
                            CompanyName = "Company8",
                            CompanyNumber = 2022030608,
                            CompanyTypeId = 2,
                            MarketId = 4
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853j",
                            CompanyName = "Company9",
                            CompanyNumber = 2022030609,
                            CompanyTypeId = 1,
                            MarketId = 4
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853k",
                            CompanyName = "Company10",
                            CompanyNumber = 2022030610,
                            CompanyTypeId = 2,
                            MarketId = 1
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853l",
                            CompanyName = "Company11",
                            CompanyNumber = 2022030611,
                            CompanyTypeId = 3,
                            MarketId = 1
                        },
                        new
                        {
                            CompanyId = "aad7a630-af1c-4952-9cb4-44b8b847853m",
                            CompanyName = "Company12",
                            CompanyNumber = 2022030612,
                            CompanyTypeId = 3,
                            MarketId = 2
                        });
                });

            modelBuilder.Entity("NotificationSchedulingAPI.Models.CompanyType", b =>
                {
                    b.Property<int>("CompanyTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyTypeId");

                    b.ToTable("CompanyTypes");

                    b.HasData(
                        new
                        {
                            CompanyTypeId = 1,
                            CompanyTypeName = "small"
                        },
                        new
                        {
                            CompanyTypeId = 2,
                            CompanyTypeName = "medium"
                        },
                        new
                        {
                            CompanyTypeId = 3,
                            CompanyTypeName = "large"
                        });
                });

            modelBuilder.Entity("NotificationSchedulingAPI.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MarketName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2");

                    b.HasKey("NotificationId");

                    b.ToTable("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
