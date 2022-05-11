﻿// <auto-generated />
using System;
using IMS.Plugins.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IMS.Plugins.EFCore.Migrations
{
    [DbContext(typeof(IMSContext))]
    partial class IMSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IMS.CoreBusiness.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"), 1L, 1);

                    b.Property<string>("InventoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            InventoryId = 1,
                            InventoryName = "Gas Engine",
                            Price = 1000.0,
                            Quantity = 1
                        },
                        new
                        {
                            InventoryId = 2,
                            InventoryName = "Body",
                            Price = 400.0,
                            Quantity = 1
                        },
                        new
                        {
                            InventoryId = 3,
                            InventoryName = "Wheel",
                            Price = 100.0,
                            Quantity = 4
                        },
                        new
                        {
                            InventoryId = 4,
                            InventoryName = "Seat",
                            Price = 50.0,
                            Quantity = 5
                        },
                        new
                        {
                            InventoryId = 5,
                            InventoryName = "Electric Engine",
                            Price = 8000.0,
                            Quantity = 2
                        },
                        new
                        {
                            InventoryId = 6,
                            InventoryName = "Battery",
                            Price = 400.0,
                            Quantity = 5
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.InventoryTransaction", b =>
                {
                    b.Property<int>("InventoryTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryTransactionId"), 1L, 1);

                    b.Property<int>("ActivityType")
                        .HasColumnType("int");

                    b.Property<string>("DoneBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<string>("PONumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityAfter")
                        .HasColumnType("int");

                    b.Property<int>("QuantityBefore")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("InventoryTransactionId");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryTransactions");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IsActive = true,
                            Price = 20000.0,
                            ProductName = "Gas Car",
                            Quantity = 1
                        },
                        new
                        {
                            ProductId = 2,
                            IsActive = true,
                            Price = 15000.0,
                            ProductName = "Electric Car",
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductInventory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryId")
                        .HasColumnType("int");

                    b.Property<int>("InventoryQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "InventoryId");

                    b.HasIndex("InventoryId");

                    b.ToTable("ProductInventory");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            InventoryId = 1,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 2,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 3,
                            InventoryQuantity = 4
                        },
                        new
                        {
                            ProductId = 1,
                            InventoryId = 4,
                            InventoryQuantity = 5
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 5,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 2,
                            InventoryQuantity = 1
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 3,
                            InventoryQuantity = 4
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 4,
                            InventoryQuantity = 5
                        },
                        new
                        {
                            ProductId = 2,
                            InventoryId = 6,
                            InventoryQuantity = 1
                        });
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductTransaction", b =>
                {
                    b.Property<int>("ProductTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductTransactionId"), 1L, 1);

                    b.Property<int>("ActivityType")
                        .HasColumnType("int");

                    b.Property<string>("DoneBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityAfter")
                        .HasColumnType("int");

                    b.Property<int>("QuantityBefore")
                        .HasColumnType("int");

                    b.Property<string>("SalesOrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductTransactionId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTransactions");
                });

            modelBuilder.Entity("IMS.CoreBusiness.InventoryTransaction", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductInventory", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Inventory", "Inventory")
                        .WithMany("ProductInventories")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IMS.CoreBusiness.Product", "Product")
                        .WithMany("ProductInventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IMS.CoreBusiness.ProductTransaction", b =>
                {
                    b.HasOne("IMS.CoreBusiness.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Inventory", b =>
                {
                    b.Navigation("ProductInventories");
                });

            modelBuilder.Entity("IMS.CoreBusiness.Product", b =>
                {
                    b.Navigation("ProductInventories");
                });
#pragma warning restore 612, 618
        }
    }
}
