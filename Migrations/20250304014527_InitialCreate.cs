using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bangazon_issues.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountType",
                columns: table => new
                {
                    AccountTypeId = table.Column<string>(type: "text", nullable: false),
                    TypeAcct = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.AccountTypeId);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    OrderStatusId = table.Column<string>(type: "text", nullable: false),
                    OrderState = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.OrderStatusId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeId = table.Column<string>(type: "text", nullable: false),
                    TypePayment = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "text", nullable: false),
                    ProductTypeId = table.Column<int>(type: "integer", nullable: false),
                    SellerUid = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    ProductTypeId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.ProductTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    AccountTypeId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Uid);
                    table.ForeignKey(
                        name: "FK_Customers_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "AccountTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SellerId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    PostalCode = table.Column<string>(type: "text", nullable: true),
                    AccountTypeId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SellerId);
                    table.ForeignKey(
                        name: "FK_Sellers_AccountType_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountType",
                        principalColumn: "AccountTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<string>(type: "text", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AccountNumber = table.Column<string>(type: "text", nullable: true),
                    PaymentTypesPaymentTypeId = table.Column<string>(type: "text", nullable: true),
                    CustomerUid = table.Column<string>(type: "text", nullable: true),
                    SellerId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_CustomerUid",
                        column: x => x.CustomerUid,
                        principalTable: "Customers",
                        principalColumn: "Uid");
                    table.ForeignKey(
                        name: "FK_Payments_PaymentTypes_PaymentTypesPaymentTypeId",
                        column: x => x.PaymentTypesPaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "PaymentTypeId");
                    table.ForeignKey(
                        name: "FK_Payments_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "SellerId");
                });

            migrationBuilder.CreateTable(
                name: "SellerDashboard",
                columns: table => new
                {
                    SellerDashBoardId = table.Column<string>(type: "text", nullable: false),
                    SellerId = table.Column<string>(type: "text", nullable: true),
                    TotalRevenue = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalOrders = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellerDashboard", x => x.SellerDashBoardId);
                    table.ForeignKey(
                        name: "FK_SellerDashboard_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "SellerId");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrdersId = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsFullfilled = table.Column<bool>(type: "boolean", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CustomerUid = table.Column<string>(type: "text", nullable: true),
                    PaymentId = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<string>(type: "text", nullable: true),
                    SellerId = table.Column<string>(type: "text", nullable: true),
                    OrderStatusId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrdersId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerUid",
                        column: x => x.CustomerUid,
                        principalTable: "Customers",
                        principalColumn: "Uid");
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "OrderStatusId");
                    table.ForeignKey(
                        name: "FK_Orders_Payments_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payments",
                        principalColumn: "PaymentId");
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_Orders_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "SellerId");
                });

            migrationBuilder.CreateTable(
                name: "CustomersOrders",
                columns: table => new
                {
                    CustomerOrderId = table.Column<string>(type: "text", nullable: false),
                    CustomerUid = table.Column<string>(type: "text", nullable: false),
                    OrdersId = table.Column<string>(type: "text", nullable: true),
                    SellerId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersOrders", x => x.CustomerOrderId);
                    table.ForeignKey(
                        name: "FK_CustomersOrders_Customers_CustomerUid",
                        column: x => x.CustomerUid,
                        principalTable: "Customers",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersOrders_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "OrdersId");
                    table.ForeignKey(
                        name: "FK_CustomersOrders_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "SellerId");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemsId = table.Column<string>(type: "text", nullable: false),
                    OrdersId = table.Column<string>(type: "text", nullable: false),
                    ProductsProductId = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemsId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "OrdersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductsProductId",
                        column: x => x.ProductsProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "SellersOrders",
                columns: table => new
                {
                    SellerOrdersId = table.Column<string>(type: "text", nullable: false),
                    SellersSellerId = table.Column<string>(type: "text", nullable: true),
                    OrdersId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SellersOrders", x => x.SellerOrdersId);
                    table.ForeignKey(
                        name: "FK_SellersOrders_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "OrdersId");
                    table.ForeignKey(
                        name: "FK_SellersOrders_Sellers_SellersSellerId",
                        column: x => x.SellersSellerId,
                        principalTable: "Sellers",
                        principalColumn: "SellerId");
                });

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "AccountTypeId", "TypeAcct" },
                values: new object[,]
                {
                    { "63d1b90b-daeb-4e69-8288-22263e33fcf0", 2 },
                    { "f21ab4a8-ed2b-4ba1-b05c-09380ad91d29", 1 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Uid", "AccountTypeId", "City", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "State" },
                values: new object[,]
                {
                    { "1", null, "Gadsden", "jon@jon.com", "Sally", "Smith", "256-490-1245", "35901", "Alabama" },
                    { "2", null, "Birmingham", "jondoe@email.com", "Jon", "Doe", "256-555-5555", "35203", "Alabama" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "OrderStatusId", "OrderState" },
                values: new object[,]
                {
                    { "14544b7a-de3b-4cbe-baef-88086336ec6c", 2 },
                    { "81fbceef-bc08-431e-b0f4-cbde246edce3", 0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrdersId", "CustomerUid", "IsFullfilled", "OrderDate", "OrderStatusId", "PaymentDate", "PaymentId", "ProductId", "Quantity", "SellerId", "TotalPrice" },
                values: new object[,]
                {
                    { "c2eb5be7-b7b7-448e-a5fe-7998d248d35f", null, true, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 3, 19, 45, 27, 130, DateTimeKind.Local).AddTicks(9515), null, null, 5, null, 350m },
                    { "e4b488ce-4320-4a0a-951c-1780cf13fadd", null, false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 3, 19, 45, 27, 130, DateTimeKind.Local).AddTicks(9472), null, null, 10, null, 450m }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "PaymentTypeId", "TypePayment" },
                values: new object[,]
                {
                    { "65648bcb-9ad5-4ce1-b386-5a198e4b10a4", 4 },
                    { "fd89cb2d-8e45-4995-afae-4eb2861e325b", 9 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "AccountNumber", "Amount", "CustomerUid", "PaymentDate", "PaymentTypesPaymentTypeId", "SellerId" },
                values: new object[,]
                {
                    { "34b5bd26-0ed7-41bc-b35c-4b3232ca90fd", "0987654321", 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { "39dfc9c0-db58-468d-8069-f5a7f1385cf2", "1234567890", 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { "c57a270b-6d4a-424d-a55f-ab7c37ce5c8e", "Gadgets are cooler", "", "Gadgets" },
                    { "f4bb1438-a0f5-4361-ab4c-b95d0e3e7355", "Widgets are cool", "", "Widgets" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateAdded", "Description", "ImageUrl", "IsAvailable", "Name", "Price", "ProductTypeId", "Quantity", "SellerUid" },
                values: new object[,]
                {
                    { "4afc9a1d-7a94-4204-a6dc-fac1c44aaf09", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A widget that does stuff", null, false, "Widget", 9.99m, 1, 100, "1" },
                    { "d40bd311-87b0-4a34-a6a5-634bb497a8da", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A gadget that does stuff", null, false, "Gadget", 19.99m, 2, 50, "2" }
                });

            migrationBuilder.InsertData(
                table: "SellerDashboard",
                columns: new[] { "SellerDashBoardId", "SellerId", "TotalOrders", "TotalRevenue" },
                values: new object[,]
                {
                    { "93d32240-c382-4c99-a9e2-5d664418d32f", null, 2, 19.98m },
                    { "cc6bc701-d3aa-4134-ba01-2c8f31c7dcc2", null, 1, 19.99m }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "AccountTypeId", "City", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "State" },
                values: new object[,]
                {
                    { "b52cf90d-b4d1-4e89-b979-e6af88787c7a", null, "Birmingham", "jsmith@jsmith.com", "John", "Smith", "256-555-5555", "35203", "Alabama" },
                    { "df3e83dd-4d01-4050-83fd-f6ca1112b2ef", null, "Decatur", "seller@email.com", "Jane", "Doe", "555-555-5555", "32323", "Georgia" }
                });

            migrationBuilder.InsertData(
                table: "SellersOrders",
                columns: new[] { "SellerOrdersId", "OrdersId", "SellersSellerId" },
                values: new object[,]
                {
                    { "0feac109-5731-480a-aba1-51c6b2b77ff5", null, null },
                    { "c1ee1fb5-2db6-4c90-b3ef-510e3641bd42", null, null }
                });

            migrationBuilder.InsertData(
                table: "CustomersOrders",
                columns: new[] { "CustomerOrderId", "CustomerUid", "OrdersId", "SellerId" },
                values: new object[,]
                {
                    { "07d2596f-58f3-4ba1-b1f6-2eae26c6c615", "1", null, null },
                    { "285a4c51-9e9d-4620-ae86-fdb1d82cf019", "2", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemsId", "OrdersId", "ProductsProductId", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { "1b6869ea-e12f-4918-8b74-10d03f0e6985", "c2eb5be7-b7b7-448e-a5fe-7998d248d35f", null, 1, 35m },
                    { "fddd2a63-75d4-4e7e-b7da-0c641f766727", "e4b488ce-4320-4a0a-951c-1780cf13fadd", null, 2, 45m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AccountTypeId",
                table: "Customers",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersOrders_CustomerUid",
                table: "CustomersOrders",
                column: "CustomerUid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomersOrders_OrdersId",
                table: "CustomersOrders",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersOrders_SellerId",
                table: "CustomersOrders",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrdersId",
                table: "OrderItems",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductsProductId",
                table: "OrderItems",
                column: "ProductsProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerUid",
                table: "Orders",
                column: "CustomerUid");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentId",
                table: "Orders",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SellerId",
                table: "Orders",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerUid",
                table: "Payments",
                column: "CustomerUid");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentTypesPaymentTypeId",
                table: "Payments",
                column: "PaymentTypesPaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SellerId",
                table: "Payments",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_SellerDashboard_SellerId",
                table: "SellerDashboard",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_AccountTypeId",
                table: "Sellers",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SellersOrders_OrdersId",
                table: "SellersOrders",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_SellersOrders_SellersSellerId",
                table: "SellersOrders",
                column: "SellersSellerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersOrders");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "SellerDashboard");

            migrationBuilder.DropTable(
                name: "SellersOrders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "AccountType");
        }
    }
}
