﻿// <auto-generated />
using System;
using Data_Access.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data_Access.Migrations
{
    [DbContext(typeof(MWDBContext))]
    [Migration("20221125033247_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.MWConfirmPin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("AdPartnerName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Channel")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HttpResponseCode")
                        .HasColumnType("int");

                    b.Property<string>("Msisdn")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("OpSubscriptionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<string>("PinCode")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("ProductId")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("PubId")
                        .HasColumnType("varchar(2)");

                    b.Property<int>("ResponseCode")
                        .HasColumnType("int");

                    b.Property<string>("ResponseMessage")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("ResultMessage")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("SourceIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SubscriptionId")
                        .HasColumnType("bigint");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrxID")
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("OpSubscriptionId")
                        .HasDatabaseName("IDX_OpsubscriptionId");

                    b.HasIndex("PinCode")
                        .HasDatabaseName("IDX_PinCode");

                    b.HasIndex("ResponseCode")
                        .HasDatabaseName("IDX_ResponseCode");

                    b.HasIndex("SubscriptionId")
                        .HasDatabaseName("IDX_SubscriptionId");

                    b.HasIndex("Msisdn", "CreateDate")
                        .HasDatabaseName("IDX_Msisdn_CreateDate");

                    b.ToTable("ConfirmPin");
                });

            modelBuilder.Entity("Entities.MWSendPin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("AdPartnerName")
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Channel")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ClientCorrelator")
                        .HasColumnType("varchar(60)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HttpResponseCode")
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Msisdn")
                        .HasColumnType("varchar(15)");

                    b.Property<long>("OpSubscriptionId")
                        .HasColumnType("bigint");

                    b.Property<string>("ProductId")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("PubId")
                        .HasColumnType("varchar(2)");

                    b.Property<int>("ResponseCode")
                        .HasColumnType("int");

                    b.Property<string>("ResponseMessage")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("ResultMessage")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("SourceIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SubscriptionId")
                        .HasColumnType("bigint");

                    b.Property<string>("TrxID")
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("OpSubscriptionId")
                        .HasDatabaseName("IDX_OpsubscriptionId");

                    b.HasIndex("ResponseCode")
                        .HasDatabaseName("IDX_ResponseCode");

                    b.HasIndex("SubscriptionId")
                        .HasDatabaseName("IDX_SubscriptionId");

                    b.HasIndex("Msisdn", "CreateDate")
                        .HasDatabaseName("IDX_Msisdn_CreateDate");

                    b.ToTable("SendPin");
                });

            modelBuilder.Entity("Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ContentBaseUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Key")
                        .HasColumnType("int");

                    b.Property<string>("LandingPageBaseUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PartnerId")
                        .HasColumnType("bigint");

                    b.Property<string>("ServiceName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Key", "PartnerId")
                        .HasDatabaseName("IDX_ProductKey_PartnerId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AppName = "megaplay",
                            ContentBaseUrl = "https://digitalboxonline.com/?sugid=cd01de3a-e5ae-434c-b926-ec127d1cde3b",
                            CreateDate = new DateTime(2022, 11, 24, 21, 32, 47, 88, DateTimeKind.Local).AddTicks(8945),
                            IsActive = true,
                            Key = 0,
                            LandingPageBaseUrl = "http://uae.digi-vibe.com/",
                            PartnerId = 900L,
                            ServiceName = "MegaPlay"
                        });
                });

            modelBuilder.Entity("Entities.Subscription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CancelDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ContentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventSource")
                        .HasColumnType("varchar(5)");

                    b.Property<int>("IdOperator")
                        .HasColumnType("int");

                    b.Property<int>("Key")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastRenew")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastSuccessfulRenew")
                        .HasColumnType("datetime2");

                    b.Property<string>("Msisdn")
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("NextRenew")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("IdOperator")
                        .HasDatabaseName("IDX_Operator");

                    b.HasIndex("LastSuccessfulRenew")
                        .HasDatabaseName("IDX_Last_Succ_Ren");

                    b.HasIndex("Status", "CreateDate")
                        .HasDatabaseName("IDX_Status_CreateDate");

                    b.ToTable("Subscription");
                });

            modelBuilder.Entity("Entities.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BillAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BillType")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KeyWord")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Msisdn")
                        .HasColumnType("varchar(15)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("TransactionId")
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("Msisdn")
                        .HasDatabaseName("IDX_Msisdn");

                    b.HasIndex("Msisdn", "BillType")
                        .HasDatabaseName("IDX_Msisdn_BillType");

                    b.ToTable("Transaction");
                });
#pragma warning restore 612, 618
        }
    }
}
