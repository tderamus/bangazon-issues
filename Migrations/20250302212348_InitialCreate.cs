using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    AccountTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AccountTypeEnum = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountType", x => x.AccountTypeId);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    OrderStatusId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.OrderStatusId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    ProductTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                    AccountTypeId = table.Column<int>(type: "integer", nullable: true)
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
                    AccountTypeId = table.Column<int>(type: "integer", nullable: true)
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
                name: "Orders",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsFullfilled = table.Column<bool>(type: "boolean", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CustomerUid = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true),
                    SellerId = table.Column<string>(type: "text", nullable: true),
                    OrderStatusId = table.Column<int>(type: "integer", nullable: true)
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
                name: "SellerDashboard",
                columns: table => new
                {
                    SellerDashBoardId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                name: "CustomersOrders",
                columns: table => new
                {
                    CustomerOrderId = table.Column<string>(type: "text", nullable: false),
                    OrdersId = table.Column<int>(type: "integer", nullable: true),
                    SellerId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersOrders", x => x.CustomerOrderId);
                    table.ForeignKey(
                        name: "FK_CustomersOrders_Customers_CustomerOrderId",
                        column: x => x.CustomerOrderId,
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
                    OrderItemsId = table.Column<int>(type: "integer", nullable: false),
                    ProductsProductId = table.Column<int>(type: "integer", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemsId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderItemsId",
                        column: x => x.OrderItemsId,
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
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AccountNumber = table.Column<string>(type: "text", nullable: true),
                    PaymentTypesPaymentTypeId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_Payments_Orders_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Orders",
                        principalColumn: "OrdersId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "SellersOrders",
                columns: table => new
                {
                    SellerOrdersId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SellersSellerId = table.Column<string>(type: "text", nullable: true),
                    OrdersId = table.Column<int>(type: "integer", nullable: true)
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
                columns: new[] { "AccountTypeId", "AccountTypeEnum" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 }
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
                column: "OrderStatusId",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrdersId", "CustomerUid", "IsFullfilled", "OrderDate", "OrderStatusId", "PaymentDate", "ProductId", "Quantity", "SellerId", "TotalPrice" },
                values: new object[,]
                {
                    { 1, null, false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 2, 15, 23, 47, 709, DateTimeKind.Local).AddTicks(4620), null, 10, null, 450m },
                    { 2, null, true, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 2, 15, 23, 47, 709, DateTimeKind.Local).AddTicks(4660), null, 5, null, 350m }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                column: "PaymentTypeId",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Widgets are cool", "", "Widgets" },
                    { 2, "Gadgets are cooler", "", "Gadgets" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateAdded", "Description", "ImageUrl", "IsAvailable", "Name", "Price", "ProductTypeId", "Quantity", "SellerUid" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A widget that does stuff", null, false, "Widget", 9.99m, 1, 100, "1" },
                    { 2, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A gadget that does stuff", null, false, "Gadget", 19.99m, 2, 50, "2" }
                });

            migrationBuilder.InsertData(
                table: "SellerDashboard",
                columns: new[] { "SellerDashBoardId", "SellerId", "TotalOrders", "TotalRevenue" },
                values: new object[,]
                {
                    { 1, null, 2, 19.98m },
                    { 2, null, 1, 19.99m }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "AccountTypeId", "City", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "State" },
                values: new object[] { "1", null, "Decatur", "seller@email.com", "Jane", "Doe", "555-555-5555", "32323", "Georgia" });

            migrationBuilder.InsertData(
                table: "SellersOrders",
                columns: new[] { "SellerOrdersId", "OrdersId", "SellersSellerId" },
                values: new object[,]
                {
                    { 1, null, null },
                    { 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "CustomersOrders",
                columns: new[] { "CustomerOrderId", "OrdersId", "SellerId" },
                values: new object[,]
                {
                    { "1", null, null },
                    { "2", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemsId", "ProductsProductId", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { 1, null, 2, 45m },
                    { 2, null, 1, 35m }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "AccountNumber", "Amount", "CustomerUid", "PaymentDate", "PaymentTypesPaymentTypeId", "SellerId" },
                values: new object[,]
                {
                    { 1, "1234567890", 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, "0987654321", 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AccountTypeId",
                table: "Customers",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersOrders_OrdersId",
                table: "CustomersOrders",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersOrders_SellerId",
                table: "CustomersOrders",
                column: "SellerId");

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
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "SellerDashboard");

            migrationBuilder.DropTable(
                name: "SellersOrders");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "AccountType");
        }
    }
}
