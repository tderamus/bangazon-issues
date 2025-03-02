﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace bangazon_issues.Migrations
{
    [DbContext(typeof(BangazonDbContext))]
    [Migration("20250302213118_UpdateAcctTypeEnumName")]
    partial class UpdateAcctTypeEnumName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("bangazon_issues.Models.AccountType", b =>
                {
                    b.Property<int>("AccountTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AccountTypeId"));

                    b.Property<int>("TypeAcct")
                        .HasColumnType("integer");

                    b.HasKey("AccountTypeId");

                    b.ToTable("AccountType");

                    b.HasData(
                        new
                        {
                            AccountTypeId = 1,
                            TypeAcct = 2
                        },
                        new
                        {
                            AccountTypeId = 2,
                            TypeAcct = 1
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.CustomerOrders", b =>
                {
                    b.Property<string>("CustomerOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<int?>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<string>("SellerId")
                        .HasColumnType("text");

                    b.HasKey("CustomerOrderId");

                    b.HasIndex("OrdersId");

                    b.HasIndex("SellerId");

                    b.ToTable("CustomersOrders");

                    b.HasData(
                        new
                        {
                            CustomerOrderId = "1"
                        },
                        new
                        {
                            CustomerOrderId = "2"
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Customers", b =>
                {
                    b.Property<string>("Uid")
                        .HasColumnType("text");

                    b.Property<int?>("AccountTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.HasKey("Uid");

                    b.HasIndex("AccountTypeId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Uid = "1",
                            City = "Gadsden",
                            Email = "jon@jon.com",
                            FirstName = "Sally",
                            LastName = "Smith",
                            PhoneNumber = "256-490-1245",
                            PostalCode = "35901",
                            State = "Alabama"
                        },
                        new
                        {
                            Uid = "2",
                            City = "Birmingham",
                            Email = "jondoe@email.com",
                            FirstName = "Jon",
                            LastName = "Doe",
                            PhoneNumber = "256-555-5555",
                            PostalCode = "35203",
                            State = "Alabama"
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.OrderItems", b =>
                {
                    b.Property<int>("OrderItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<int?>("ProductsProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.HasKey("OrderItemsId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemsId = 1,
                            Quantity = 2,
                            TotalPrice = 45m
                        },
                        new
                        {
                            OrderItemsId = 2,
                            Quantity = 1,
                            TotalPrice = 35m
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderStatusId"));

                    b.HasKey("OrderStatusId");

                    b.ToTable("OrderStatus");

                    b.HasData(
                        new
                        {
                            OrderStatusId = 1
                        },
                        new
                        {
                            OrderStatusId = 2
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Orders", b =>
                {
                    b.Property<int>("OrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrdersId"));

                    b.Property<string>("CustomerUid")
                        .HasColumnType("text");

                    b.Property<bool>("IsFullfilled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("OrderStatusId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("SellerId")
                        .HasColumnType("text");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.HasKey("OrdersId");

                    b.HasIndex("CustomerUid");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SellerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrdersId = 1,
                            IsFullfilled = false,
                            OrderDate = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentDate = new DateTime(2025, 3, 2, 15, 31, 17, 788, DateTimeKind.Local).AddTicks(5472),
                            Quantity = 10,
                            TotalPrice = 450m
                        },
                        new
                        {
                            OrdersId = 2,
                            IsFullfilled = true,
                            OrderDate = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentDate = new DateTime(2025, 3, 2, 15, 31, 17, 788, DateTimeKind.Local).AddTicks(5509),
                            Quantity = 5,
                            TotalPrice = 350m
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.PaymentTypes", b =>
                {
                    b.Property<int>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PaymentTypeId"));

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            PaymentTypeId = 1
                        },
                        new
                        {
                            PaymentTypeId = 2
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Payments", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("text");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("CustomerUid")
                        .HasColumnType("text");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("PaymentTypesPaymentTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("SellerId")
                        .HasColumnType("text");

                    b.HasKey("PaymentId");

                    b.HasIndex("CustomerUid");

                    b.HasIndex("PaymentTypesPaymentTypeId");

                    b.HasIndex("SellerId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            PaymentId = 1,
                            AccountNumber = "1234567890",
                            Amount = 0m,
                            PaymentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            PaymentId = 2,
                            AccountNumber = "0987654321",
                            Amount = 0m,
                            PaymentDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.ProductTypes", b =>
                {
                    b.Property<int>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductTypeId"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("ProductTypeId");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            ProductTypeId = 1,
                            Description = "Widgets are cool",
                            ImageUrl = "",
                            Name = "Widgets"
                        },
                        new
                        {
                            ProductTypeId = 2,
                            Description = "Gadgets are cooler",
                            ImageUrl = "",
                            Name = "Gadgets"
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("SellerUid")
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            DateAdded = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A widget that does stuff",
                            IsAvailable = false,
                            Name = "Widget",
                            Price = 9.99m,
                            ProductTypeId = 1,
                            Quantity = 100,
                            SellerUid = "1"
                        },
                        new
                        {
                            ProductId = 2,
                            DateAdded = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A gadget that does stuff",
                            IsAvailable = false,
                            Name = "Gadget",
                            Price = 19.99m,
                            ProductTypeId = 2,
                            Quantity = 50,
                            SellerUid = "2"
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.SellerDashboard", b =>
                {
                    b.Property<int>("SellerDashBoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SellerDashBoardId"));

                    b.Property<string>("SellerId")
                        .HasColumnType("text");

                    b.Property<int>("TotalOrders")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalRevenue")
                        .HasColumnType("numeric");

                    b.HasKey("SellerDashBoardId");

                    b.HasIndex("SellerId");

                    b.ToTable("SellerDashboard");

                    b.HasData(
                        new
                        {
                            SellerDashBoardId = 1,
                            TotalOrders = 2,
                            TotalRevenue = 19.98m
                        },
                        new
                        {
                            SellerDashBoardId = 2,
                            TotalOrders = 1,
                            TotalRevenue = 19.99m
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.SellerOrders", b =>
                {
                    b.Property<int>("SellerOrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SellerOrdersId"));

                    b.Property<int?>("OrdersId")
                        .HasColumnType("integer");

                    b.Property<string>("SellersSellerId")
                        .HasColumnType("text");

                    b.HasKey("SellerOrdersId");

                    b.HasIndex("OrdersId");

                    b.HasIndex("SellersSellerId");

                    b.ToTable("SellersOrders");

                    b.HasData(
                        new
                        {
                            SellerOrdersId = 1
                        },
                        new
                        {
                            SellerOrdersId = 2
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Sellers", b =>
                {
                    b.Property<string>("SellerId")
                        .HasColumnType("text");

                    b.Property<int?>("AccountTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.HasKey("SellerId");

                    b.HasIndex("AccountTypeId");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            SellerId = "1",
                            City = "Decatur",
                            Email = "seller@email.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            PhoneNumber = "555-555-5555",
                            PostalCode = "32323",
                            State = "Georgia"
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.CustomerOrders", b =>
                {
                    b.HasOne("bangazon_issues.Models.Customers", "Customer")
                        .WithOne("CustomerOrders")
                        .HasForeignKey("bangazon_issues.Models.CustomerOrders", "CustomerOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bangazon_issues.Models.Orders", "Orders")
                        .WithMany()
                        .HasForeignKey("OrdersId");

                    b.HasOne("bangazon_issues.Models.Sellers", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.Navigation("Customer");

                    b.Navigation("Orders");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("bangazon_issues.Models.Customers", b =>
                {
                    b.HasOne("bangazon_issues.Models.AccountType", "AccountType")
                        .WithMany()
                        .HasForeignKey("AccountTypeId");

                    b.Navigation("AccountType");
                });

            modelBuilder.Entity("bangazon_issues.Models.OrderItems", b =>
                {
                    b.HasOne("bangazon_issues.Models.Orders", "Orders")
                        .WithOne("OrderItems")
                        .HasForeignKey("bangazon_issues.Models.OrderItems", "OrderItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bangazon_issues.Models.Products", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsProductId");

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("bangazon_issues.Models.Orders", b =>
                {
                    b.HasOne("bangazon_issues.Models.Customers", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerUid");

                    b.HasOne("bangazon_issues.Models.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId");

                    b.HasOne("bangazon_issues.Models.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("bangazon_issues.Models.Sellers", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.Navigation("Customer");

                    b.Navigation("OrderStatus");

                    b.Navigation("Product");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("bangazon_issues.Models.Payments", b =>
                {
                    b.HasOne("bangazon_issues.Models.Customers", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerUid");

                    b.HasOne("bangazon_issues.Models.Orders", "Orders")
                        .WithOne("Payment")
                        .HasForeignKey("bangazon_issues.Models.Payments", "PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bangazon_issues.Models.PaymentTypes", "PaymentTypes")
                        .WithMany()
                        .HasForeignKey("PaymentTypesPaymentTypeId");

                    b.HasOne("bangazon_issues.Models.Sellers", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.Navigation("Customer");

                    b.Navigation("Orders");

                    b.Navigation("PaymentTypes");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("bangazon_issues.Models.SellerDashboard", b =>
                {
                    b.HasOne("bangazon_issues.Models.Sellers", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("bangazon_issues.Models.SellerOrders", b =>
                {
                    b.HasOne("bangazon_issues.Models.Orders", "Orders")
                        .WithMany()
                        .HasForeignKey("OrdersId");

                    b.HasOne("bangazon_issues.Models.Sellers", "Sellers")
                        .WithMany()
                        .HasForeignKey("SellersSellerId");

                    b.Navigation("Orders");

                    b.Navigation("Sellers");
                });

            modelBuilder.Entity("bangazon_issues.Models.Sellers", b =>
                {
                    b.HasOne("bangazon_issues.Models.AccountType", "AccountType")
                        .WithMany()
                        .HasForeignKey("AccountTypeId");

                    b.Navigation("AccountType");
                });

            modelBuilder.Entity("bangazon_issues.Models.Customers", b =>
                {
                    b.Navigation("CustomerOrders");
                });

            modelBuilder.Entity("bangazon_issues.Models.Orders", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}
