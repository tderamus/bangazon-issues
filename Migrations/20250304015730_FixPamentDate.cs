using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bangazon_issues.Migrations
{
    /// <inheritdoc />
    public partial class FixPamentDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "AccountTypeId",
                keyValue: "63d1b90b-daeb-4e69-8288-22263e33fcf0");

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "AccountTypeId",
                keyValue: "f21ab4a8-ed2b-4ba1-b05c-09380ad91d29");

            migrationBuilder.DeleteData(
                table: "CustomersOrders",
                keyColumn: "CustomerOrderId",
                keyValue: "07d2596f-58f3-4ba1-b1f6-2eae26c6c615");

            migrationBuilder.DeleteData(
                table: "CustomersOrders",
                keyColumn: "CustomerOrderId",
                keyValue: "285a4c51-9e9d-4620-ae86-fdb1d82cf019");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: "1b6869ea-e12f-4918-8b74-10d03f0e6985");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: "fddd2a63-75d4-4e7e-b7da-0c641f766727");

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: "14544b7a-de3b-4cbe-baef-88086336ec6c");

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: "81fbceef-bc08-431e-b0f4-cbde246edce3");

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: "65648bcb-9ad5-4ce1-b386-5a198e4b10a4");

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: "fd89cb2d-8e45-4995-afae-4eb2861e325b");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "34b5bd26-0ed7-41bc-b35c-4b3232ca90fd");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "39dfc9c0-db58-468d-8069-f5a7f1385cf2");

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: "c57a270b-6d4a-424d-a55f-ab7c37ce5c8e");

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: "f4bb1438-a0f5-4361-ab4c-b95d0e3e7355");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "4afc9a1d-7a94-4204-a6dc-fac1c44aaf09");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "d40bd311-87b0-4a34-a6a5-634bb497a8da");

            migrationBuilder.DeleteData(
                table: "SellerDashboard",
                keyColumn: "SellerDashBoardId",
                keyValue: "93d32240-c382-4c99-a9e2-5d664418d32f");

            migrationBuilder.DeleteData(
                table: "SellerDashboard",
                keyColumn: "SellerDashBoardId",
                keyValue: "cc6bc701-d3aa-4134-ba01-2c8f31c7dcc2");

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: "b52cf90d-b4d1-4e89-b979-e6af88787c7a");

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: "df3e83dd-4d01-4050-83fd-f6ca1112b2ef");

            migrationBuilder.DeleteData(
                table: "SellersOrders",
                keyColumn: "SellerOrdersId",
                keyValue: "0feac109-5731-480a-aba1-51c6b2b77ff5");

            migrationBuilder.DeleteData(
                table: "SellersOrders",
                keyColumn: "SellerOrdersId",
                keyValue: "c1ee1fb5-2db6-4c90-b3ef-510e3641bd42");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: "c2eb5be7-b7b7-448e-a5fe-7998d248d35f");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: "e4b488ce-4320-4a0a-951c-1780cf13fadd");

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "AccountTypeId", "TypeAcct" },
                values: new object[,]
                {
                    { "10a49ecf-dc8b-480e-b2e5-81b5d890eb32", 1 },
                    { "6c13294a-9062-44d5-b04b-2b13abe34042", 2 }
                });

            migrationBuilder.InsertData(
                table: "CustomersOrders",
                columns: new[] { "CustomerOrderId", "CustomerUid", "OrdersId", "SellerId" },
                values: new object[,]
                {
                    { "7878ade1-1d3b-4f2e-b50c-97ae64f7e22d", "1", null, null },
                    { "8a3c4d9a-c051-401b-9a31-f0fbbb74ee9c", "2", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "OrderStatusId", "OrderState" },
                values: new object[,]
                {
                    { "70f445cc-70d5-439b-84c0-952a579403f9", 2 },
                    { "7cb507c6-d902-47ef-ad1c-d8dcaf2f4ec9", 0 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrdersId", "CustomerUid", "IsFullfilled", "OrderDate", "OrderStatusId", "PaymentDate", "PaymentId", "ProductId", "Quantity", "SellerId", "TotalPrice" },
                values: new object[,]
                {
                    { "4cec8fb7-3a24-4226-b10a-c66dbba9ce50", null, true, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 3, 19, 57, 30, 49, DateTimeKind.Local).AddTicks(8924), null, null, 5, null, 350m },
                    { "b17a85a8-9a37-4f1e-aeed-fa8069720d24", null, false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 3, 19, 57, 30, 49, DateTimeKind.Local).AddTicks(8885), null, null, 10, null, 450m }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "PaymentTypeId", "TypePayment" },
                values: new object[,]
                {
                    { "d4379434-72c1-48bf-a750-4471cff4cca4", 9 },
                    { "e1ade010-ab27-4b8f-a007-c3050b0937a2", 4 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "AccountNumber", "Amount", "CustomerUid", "PaymentDate", "PaymentTypesPaymentTypeId", "SellerId" },
                values: new object[,]
                {
                    { "ad60afa7-596e-4d0a-b7c0-1cd871862e9e", "0987654321", 0m, null, new DateTime(2025, 3, 4, 1, 57, 30, 49, DateTimeKind.Utc).AddTicks(8965), null, null },
                    { "ca171bb6-9f01-4135-9086-a8378f68e1af", "1234567890", 0m, null, new DateTime(2025, 3, 4, 1, 57, 30, 49, DateTimeKind.Utc).AddTicks(8963), null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { "5ad2ca3c-ba71-4f3a-8503-7914b841e55f", "Gadgets are cooler", "", "Gadgets" },
                    { "85cc7878-8092-4427-8c8b-5171d91dca27", "Widgets are cool", "", "Widgets" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateAdded", "Description", "ImageUrl", "IsAvailable", "Name", "Price", "ProductTypeId", "Quantity", "SellerUid" },
                values: new object[,]
                {
                    { "1cccf59f-0ee4-4be9-8e4b-936cbbd66315", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A gadget that does stuff", null, false, "Gadget", 19.99m, 2, 50, "2" },
                    { "20438af5-591a-4297-9b7d-75d553ee2ca3", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A widget that does stuff", null, false, "Widget", 9.99m, 1, 100, "1" }
                });

            migrationBuilder.InsertData(
                table: "SellerDashboard",
                columns: new[] { "SellerDashBoardId", "SellerId", "TotalOrders", "TotalRevenue" },
                values: new object[,]
                {
                    { "2411acfd-d94f-4f71-936c-629343f6f26a", null, 2, 19.98m },
                    { "7d348692-88e3-4a32-acc8-4ccc47914efa", null, 1, 19.99m }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "AccountTypeId", "City", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "State" },
                values: new object[,]
                {
                    { "4df3c58c-bf0b-404e-bfac-4ec2b2755d77", null, "Decatur", "seller@email.com", "Jane", "Doe", "555-555-5555", "32323", "Georgia" },
                    { "cf0834b0-6a9b-448a-9a39-bdf0d2617e81", null, "Birmingham", "jsmith@jsmith.com", "John", "Smith", "256-555-5555", "35203", "Alabama" }
                });

            migrationBuilder.InsertData(
                table: "SellersOrders",
                columns: new[] { "SellerOrdersId", "OrdersId", "SellersSellerId" },
                values: new object[,]
                {
                    { "27e60f2c-7fea-420f-9237-acf0c3868bf3", null, null },
                    { "f64925f6-da12-487f-ad6a-b8e2754c685b", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemsId", "OrdersId", "ProductsProductId", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { "a2a2331b-525a-4927-a51e-ff2d3ce6da93", "b17a85a8-9a37-4f1e-aeed-fa8069720d24", null, 2, 45m },
                    { "d2b7783a-9271-409f-8c28-da684fe28184", "4cec8fb7-3a24-4226-b10a-c66dbba9ce50", null, 1, 35m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "AccountTypeId",
                keyValue: "10a49ecf-dc8b-480e-b2e5-81b5d890eb32");

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "AccountTypeId",
                keyValue: "6c13294a-9062-44d5-b04b-2b13abe34042");

            migrationBuilder.DeleteData(
                table: "CustomersOrders",
                keyColumn: "CustomerOrderId",
                keyValue: "7878ade1-1d3b-4f2e-b50c-97ae64f7e22d");

            migrationBuilder.DeleteData(
                table: "CustomersOrders",
                keyColumn: "CustomerOrderId",
                keyValue: "8a3c4d9a-c051-401b-9a31-f0fbbb74ee9c");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: "a2a2331b-525a-4927-a51e-ff2d3ce6da93");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: "d2b7783a-9271-409f-8c28-da684fe28184");

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: "70f445cc-70d5-439b-84c0-952a579403f9");

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: "7cb507c6-d902-47ef-ad1c-d8dcaf2f4ec9");

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: "d4379434-72c1-48bf-a750-4471cff4cca4");

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: "e1ade010-ab27-4b8f-a007-c3050b0937a2");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "ad60afa7-596e-4d0a-b7c0-1cd871862e9e");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "ca171bb6-9f01-4135-9086-a8378f68e1af");

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: "5ad2ca3c-ba71-4f3a-8503-7914b841e55f");

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: "85cc7878-8092-4427-8c8b-5171d91dca27");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "1cccf59f-0ee4-4be9-8e4b-936cbbd66315");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "20438af5-591a-4297-9b7d-75d553ee2ca3");

            migrationBuilder.DeleteData(
                table: "SellerDashboard",
                keyColumn: "SellerDashBoardId",
                keyValue: "2411acfd-d94f-4f71-936c-629343f6f26a");

            migrationBuilder.DeleteData(
                table: "SellerDashboard",
                keyColumn: "SellerDashBoardId",
                keyValue: "7d348692-88e3-4a32-acc8-4ccc47914efa");

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: "4df3c58c-bf0b-404e-bfac-4ec2b2755d77");

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: "cf0834b0-6a9b-448a-9a39-bdf0d2617e81");

            migrationBuilder.DeleteData(
                table: "SellersOrders",
                keyColumn: "SellerOrdersId",
                keyValue: "27e60f2c-7fea-420f-9237-acf0c3868bf3");

            migrationBuilder.DeleteData(
                table: "SellersOrders",
                keyColumn: "SellerOrdersId",
                keyValue: "f64925f6-da12-487f-ad6a-b8e2754c685b");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: "4cec8fb7-3a24-4226-b10a-c66dbba9ce50");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: "b17a85a8-9a37-4f1e-aeed-fa8069720d24");

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "AccountTypeId", "TypeAcct" },
                values: new object[,]
                {
                    { "63d1b90b-daeb-4e69-8288-22263e33fcf0", 2 },
                    { "f21ab4a8-ed2b-4ba1-b05c-09380ad91d29", 1 }
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
                table: "OrderItems",
                columns: new[] { "OrderItemsId", "OrdersId", "ProductsProductId", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { "1b6869ea-e12f-4918-8b74-10d03f0e6985", "c2eb5be7-b7b7-448e-a5fe-7998d248d35f", null, 1, 35m },
                    { "fddd2a63-75d4-4e7e-b7da-0c641f766727", "e4b488ce-4320-4a0a-951c-1780cf13fadd", null, 2, 45m }
                });
        }
    }
}
