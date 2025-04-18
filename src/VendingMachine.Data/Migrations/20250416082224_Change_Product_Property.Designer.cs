﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VendingMachine.Data;

#nullable disable

namespace VendingMachine.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20250416082224_Change_Product_Property")]
    partial class Change_Product_Property
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VendingMachine.Core.Entities.BrandEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("BrandEntity");
                });

            modelBuilder.Entity("VendingMachine.Core.Entities.CoinsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<decimal>("Denomination")
                        .HasColumnType("decimal(18,0)");

                    b.Property<bool>("isBlocked")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("CoinsEntity");
                });

            modelBuilder.Entity("VendingMachine.Core.Entities.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("OrderEntity");
                });

            modelBuilder.Entity("VendingMachine.Core.Entities.OrderItemEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrderEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductEntityId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("ProductEntityId");

                    b.ToTable("OrderItemEntity");
                });

            modelBuilder.Entity("VendingMachine.Core.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BrandEntityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BrandEntityId");

                    b.ToTable("ProductEntity");
                });

            modelBuilder.Entity("VendingMachine.Core.Entities.OrderItemEntity", b =>
                {
                    b.HasOne("VendingMachine.Core.Entities.OrderEntity", "OrderEntity")
                        .WithMany("Items")
                        .HasForeignKey("OrderEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VendingMachine.Core.Entities.ProductEntity", "ProductEntity")
                        .WithMany()
                        .HasForeignKey("ProductEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderEntity");

                    b.Navigation("ProductEntity");
                });

            modelBuilder.Entity("VendingMachine.Core.Entities.ProductEntity", b =>
                {
                    b.HasOne("VendingMachine.Core.Entities.BrandEntity", "BrandEntity")
                        .WithMany("ProductsEntity")
                        .HasForeignKey("BrandEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BrandEntity");
                });

            modelBuilder.Entity("VendingMachine.Core.Entities.BrandEntity", b =>
                {
                    b.Navigation("ProductsEntity");
                });

            modelBuilder.Entity("VendingMachine.Core.Entities.OrderEntity", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
