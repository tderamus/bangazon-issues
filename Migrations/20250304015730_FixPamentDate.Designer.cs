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
    [Migration("20250304015730_FixPamentDate")]
    partial class FixPamentDate
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
                    b.Property<string>("AccountTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<int>("TypeAcct")
                        .HasColumnType("integer");

                    b.HasKey("AccountTypeId");

                    b.ToTable("AccountType");

                    b.HasData(
                        new
                        {
                            AccountTypeId = "6c13294a-9062-44d5-b04b-2b13abe34042",
                            TypeAcct = 2
                        },
                        new
                        {
                            AccountTypeId = "10a49ecf-dc8b-480e-b2e5-81b5d890eb32",
                            TypeAcct = 1
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.CustomerOrders", b =>
                {
                    b.Property<string>("CustomerOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("CustomerUid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrdersId")
                        .HasColumnType("text");

                    b.Property<string>("SellerId")
                        .HasColumnType("text");

                    b.HasKey("CustomerOrderId");

                    b.HasIndex("CustomerUid")
                        .IsUnique();

                    b.HasIndex("OrdersId");

                    b.HasIndex("SellerId");

                    b.ToTable("CustomersOrders");

                    b.HasData(
                        new
                        {
                            CustomerOrderId = "7878ade1-1d3b-4f2e-b50c-97ae64f7e22d",
                            CustomerUid = "1"
                        },
                        new
                        {
                            CustomerOrderId = "8a3c4d9a-c051-401b-9a31-f0fbbb74ee9c",
                            CustomerUid = "2"
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Customers", b =>
                {
                    b.Property<string>("Uid")
                        .HasColumnType("text");

                    b.Property<string>("AccountTypeId")
                        .HasColumnType("text");

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
                    b.Property<string>("OrderItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("OrdersId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProductsProductId")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.HasKey("OrderItemsId");

                    b.HasIndex("OrdersId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemsId = "a2a2331b-525a-4927-a51e-ff2d3ce6da93",
                            OrdersId = "b17a85a8-9a37-4f1e-aeed-fa8069720d24",
                            Quantity = 2,
                            TotalPrice = 45m
                        },
                        new
                        {
                            OrderItemsId = "d2b7783a-9271-409f-8c28-da684fe28184",
                            OrdersId = "4cec8fb7-3a24-4226-b10a-c66dbba9ce50",
                            Quantity = 1,
                            TotalPrice = 35m
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.OrderStatus", b =>
                {
                    b.Property<string>("OrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<int>("OrderState")
                        .HasColumnType("integer");

                    b.HasKey("OrderStatusId");

                    b.ToTable("OrderStatus");

                    b.HasData(
                        new
                        {
                            OrderStatusId = "7cb507c6-d902-47ef-ad1c-d8dcaf2f4ec9",
                            OrderState = 0
                        },
                        new
                        {
                            OrderStatusId = "70f445cc-70d5-439b-84c0-952a579403f9",
                            OrderState = 2
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Orders", b =>
                {
                    b.Property<string>("OrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("CustomerUid")
                        .HasColumnType("text");

                    b.Property<bool>("IsFullfilled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("OrderStatusId")
                        .HasColumnType("text");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PaymentId")
                        .HasColumnType("text");

                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("SellerId")
                        .HasColumnType("text");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("numeric");

                    b.HasKey("OrdersId");

                    b.HasIndex("CustomerUid");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.HasIndex("SellerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrdersId = "b17a85a8-9a37-4f1e-aeed-fa8069720d24",
                            IsFullfilled = false,
                            OrderDate = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentDate = new DateTime(2025, 3, 3, 19, 57, 30, 49, DateTimeKind.Local).AddTicks(8885),
                            Quantity = 10,
                            TotalPrice = 450m
                        },
                        new
                        {
                            OrdersId = "4cec8fb7-3a24-4226-b10a-c66dbba9ce50",
                            IsFullfilled = true,
                            OrderDate = new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentDate = new DateTime(2025, 3, 3, 19, 57, 30, 49, DateTimeKind.Local).AddTicks(8924),
                            Quantity = 5,
                            TotalPrice = 350m
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.PaymentTypes", b =>
                {
                    b.Property<string>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<int>("TypePayment")
                        .HasColumnType("integer");

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            PaymentTypeId = "e1ade010-ab27-4b8f-a007-c3050b0937a2",
                            TypePayment = 4
                        },
                        new
                        {
                            PaymentTypeId = "d4379434-72c1-48bf-a750-4471cff4cca4",
                            TypePayment = 9
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Payments", b =>
                {
                    b.Property<string>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("text");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("CustomerUid")
                        .HasColumnType("text");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PaymentTypesPaymentTypeId")
                        .HasColumnType("text");

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
                            PaymentId = "ca171bb6-9f01-4135-9086-a8378f68e1af",
                            AccountNumber = "1234567890",
                            Amount = 0m,
                            PaymentDate = new DateTime(2025, 3, 4, 1, 57, 30, 49, DateTimeKind.Utc).AddTicks(8963)
                        },
                        new
                        {
                            PaymentId = "ad60afa7-596e-4d0a-b7c0-1cd871862e9e",
                            AccountNumber = "0987654321",
                            Amount = 0m,
                            PaymentDate = new DateTime(2025, 3, 4, 1, 57, 30, 49, DateTimeKind.Utc).AddTicks(8965)
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.ProductTypes", b =>
                {
                    b.Property<string>("ProductTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

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
                            ProductTypeId = "85cc7878-8092-4427-8c8b-5171d91dca27",
                            Description = "Widgets are cool",
                            ImageUrl = "",
                            Name = "Widgets"
                        },
                        new
                        {
                            ProductTypeId = "5ad2ca3c-ba71-4f3a-8503-7914b841e55f",
                            Description = "Gadgets are cooler",
                            ImageUrl = "",
                            Name = "Gadgets"
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Products", b =>
                {
                    b.Property<string>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

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
                            ProductId = "20438af5-591a-4297-9b7d-75d553ee2ca3",
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
                            ProductId = "1cccf59f-0ee4-4be9-8e4b-936cbbd66315",
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
                    b.Property<string>("SellerDashBoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

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
                            SellerDashBoardId = "2411acfd-d94f-4f71-936c-629343f6f26a",
                            TotalOrders = 2,
                            TotalRevenue = 19.98m
                        },
                        new
                        {
                            SellerDashBoardId = "7d348692-88e3-4a32-acc8-4ccc47914efa",
                            TotalOrders = 1,
                            TotalRevenue = 19.99m
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.SellerOrders", b =>
                {
                    b.Property<string>("SellerOrdersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("OrdersId")
                        .HasColumnType("text");

                    b.Property<string>("SellersSellerId")
                        .HasColumnType("text");

                    b.HasKey("SellerOrdersId");

                    b.HasIndex("OrdersId");

                    b.HasIndex("SellersSellerId");

                    b.ToTable("SellersOrders");

                    b.HasData(
                        new
                        {
                            SellerOrdersId = "f64925f6-da12-487f-ad6a-b8e2754c685b"
                        },
                        new
                        {
                            SellerOrdersId = "27e60f2c-7fea-420f-9237-acf0c3868bf3"
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.Sellers", b =>
                {
                    b.Property<string>("SellerId")
                        .HasColumnType("text");

                    b.Property<string>("AccountTypeId")
                        .HasColumnType("text");

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
                            SellerId = "4df3c58c-bf0b-404e-bfac-4ec2b2755d77",
                            City = "Decatur",
                            Email = "seller@email.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            PhoneNumber = "555-555-5555",
                            PostalCode = "32323",
                            State = "Georgia"
                        },
                        new
                        {
                            SellerId = "cf0834b0-6a9b-448a-9a39-bdf0d2617e81",
                            City = "Birmingham",
                            Email = "jsmith@jsmith.com",
                            FirstName = "John",
                            LastName = "Smith",
                            PhoneNumber = "256-555-5555",
                            PostalCode = "35203",
                            State = "Alabama"
                        });
                });

            modelBuilder.Entity("bangazon_issues.Models.CustomerOrders", b =>
                {
                    b.HasOne("bangazon_issues.Models.Customers", "Customer")
                        .WithOne("CustomerOrders")
                        .HasForeignKey("bangazon_issues.Models.CustomerOrders", "CustomerUid")
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
                        .WithMany("OrderItems")
                        .HasForeignKey("OrdersId")
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

                    b.HasOne("bangazon_issues.Models.Payments", "Payment")
                        .WithOne("Orders")
                        .HasForeignKey("bangazon_issues.Models.Orders", "PaymentId");

                    b.HasOne("bangazon_issues.Models.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("bangazon_issues.Models.Sellers", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.Navigation("Customer");

                    b.Navigation("OrderStatus");

                    b.Navigation("Payment");

                    b.Navigation("Product");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("bangazon_issues.Models.Payments", b =>
                {
                    b.HasOne("bangazon_issues.Models.Customers", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerUid");

                    b.HasOne("bangazon_issues.Models.PaymentTypes", "PaymentTypes")
                        .WithMany()
                        .HasForeignKey("PaymentTypesPaymentTypeId");

                    b.HasOne("bangazon_issues.Models.Sellers", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.Navigation("Customer");

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
                });

            modelBuilder.Entity("bangazon_issues.Models.Payments", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
