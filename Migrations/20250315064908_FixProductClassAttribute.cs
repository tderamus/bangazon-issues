using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bangazon_issues.Migrations
{
    /// <inheritdoc />
    public partial class FixProductClassAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ProductTypesProductTypeId",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AccountType",
                columns: new[] { "AccountTypeId", "TypeAcct" },
                values: new object[,]
                {
                    { "23a72339-578d-486c-927e-baadb41a0e12", 2 },
                    { "9f1b36f6-4b6a-4b61-b1c6-ac99b148779b", 1 }
                });

            migrationBuilder.InsertData(
                table: "CustomersOrders",
                columns: new[] { "CustomerOrderId", "CustomerUid", "OrdersId", "SellerId" },
                values: new object[,]
                {
                    { "930a9765-6212-48d1-a792-0897d17b00c1", "2", null, null },
                    { "b16c5b97-bf92-4cf3-af75-7e99f8b9df98", "1", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "OrderStatusId", "OrderState" },
                values: new object[,]
                {
                    { "a24f5bfb-d0c9-4a0f-bb90-0162a7c7f712", 0 },
                    { "ad0da008-a467-46e1-b01e-dbaaa3e9e0d3", 2 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrdersId", "CustomerUid", "IsFullfilled", "OrderDate", "OrderStatusId", "PaymentDate", "PaymentId", "ProductId", "Quantity", "SellerId", "TotalPrice" },
                values: new object[,]
                {
                    { "2ad4d0bb-7022-4537-a235-05d1065bbd60", null, false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 15, 1, 49, 7, 285, DateTimeKind.Local).AddTicks(3293), null, null, 10, null, 450m },
                    { "9e7ee5dd-f59e-483b-9ba0-527bccdd0951", null, true, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 15, 1, 49, 7, 285, DateTimeKind.Local).AddTicks(3332), null, null, 5, null, 350m }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "PaymentTypeId", "TypePayment" },
                values: new object[,]
                {
                    { "bf3dd7c4-55b3-4e41-8ec5-47ea60846bea", 9 },
                    { "d6a0c34c-e091-42e6-bbb9-64ee358513f1", 4 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "AccountNumber", "Amount", "CustomerUid", "PaymentDate", "PaymentTypesPaymentTypeId", "SellerId" },
                values: new object[,]
                {
                    { "6c82bf61-e2ed-416d-9723-ff2dde8c5a17", "1234567890", 0m, null, new DateTime(2025, 3, 15, 6, 49, 7, 285, DateTimeKind.Utc).AddTicks(3371), null, null },
                    { "d322513c-d6fa-45ba-8580-bb8316527bc0", "0987654321", 0m, null, new DateTime(2025, 3, 15, 6, 49, 7, 285, DateTimeKind.Utc).AddTicks(3372), null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { "07240c70-c850-4a01-8a2a-36196be3dbc0", "Widgets are cool", "", "Widgets" },
                    { "bf25c8fc-3e63-49c6-8509-97eab9da0f3f", "Gadgets are cooler", "", "Gadgets" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateAdded", "Description", "ImageUrl", "IsAvailable", "Name", "Price", "ProductTypesProductTypeId", "Quantity", "SellerUid" },
                values: new object[,]
                {
                    { "68c0fbec-c4a3-4670-b931-a5e64a087682", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A widget that does stuff", null, false, "Widget", 9.99m, null, 100, "1" },
                    { "d29ff325-3b9e-4334-ad7f-8a8a0268016a", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A gadget that does stuff", null, false, "Gadget", 19.99m, null, 50, "2" }
                });

            migrationBuilder.InsertData(
                table: "SellerDashboard",
                columns: new[] { "SellerDashBoardId", "SellerId", "TotalOrders", "TotalRevenue" },
                values: new object[,]
                {
                    { "d72664a5-406b-403f-a318-11aa79b0fb24", null, 1, 19.99m },
                    { "d76ba516-d518-40ef-b50e-ad9f405e6870", null, 2, 19.98m }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "AccountTypeId", "City", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "State" },
                values: new object[,]
                {
                    { "7e310437-f2c5-4dce-a9ef-3eceaae86259", null, "Birmingham", "jsmith@jsmith.com", "John", "Smith", "256-555-5555", "35203", "Alabama" },
                    { "bd47531f-af53-4a3c-b187-fb553a3c8292", null, "Decatur", "seller@email.com", "Jane", "Doe", "555-555-5555", "32323", "Georgia" }
                });

            migrationBuilder.InsertData(
                table: "SellersOrders",
                columns: new[] { "SellerOrdersId", "OrdersId", "SellersSellerId" },
                values: new object[,]
                {
                    { "3a24770a-35e5-4a5d-bf77-cfbda1ed0bf3", null, null },
                    { "5200954e-2c71-449d-a755-9f5c9deed157", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemsId", "OrdersId", "ProductsProductId", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { "3a49491c-f6f9-41dd-aaa3-01945f1e5a66", "2ad4d0bb-7022-4537-a235-05d1065bbd60", null, 2, 45m },
                    { "56ba70e2-f581-4161-8bd4-a6838897e1c7", "9e7ee5dd-f59e-483b-9ba0-527bccdd0951", null, 1, 35m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypesProductTypeId",
                table: "Products",
                column: "ProductTypesProductTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypesProductTypeId",
                table: "Products",
                column: "ProductTypesProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypesProductTypeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypesProductTypeId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "AccountTypeId",
                keyValue: "23a72339-578d-486c-927e-baadb41a0e12");

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "AccountTypeId",
                keyValue: "9f1b36f6-4b6a-4b61-b1c6-ac99b148779b");

            migrationBuilder.DeleteData(
                table: "CustomersOrders",
                keyColumn: "CustomerOrderId",
                keyValue: "930a9765-6212-48d1-a792-0897d17b00c1");

            migrationBuilder.DeleteData(
                table: "CustomersOrders",
                keyColumn: "CustomerOrderId",
                keyValue: "b16c5b97-bf92-4cf3-af75-7e99f8b9df98");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: "3a49491c-f6f9-41dd-aaa3-01945f1e5a66");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: "56ba70e2-f581-4161-8bd4-a6838897e1c7");

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: "a24f5bfb-d0c9-4a0f-bb90-0162a7c7f712");

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: "ad0da008-a467-46e1-b01e-dbaaa3e9e0d3");

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: "bf3dd7c4-55b3-4e41-8ec5-47ea60846bea");

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: "d6a0c34c-e091-42e6-bbb9-64ee358513f1");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "6c82bf61-e2ed-416d-9723-ff2dde8c5a17");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "d322513c-d6fa-45ba-8580-bb8316527bc0");

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: "07240c70-c850-4a01-8a2a-36196be3dbc0");

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: "bf25c8fc-3e63-49c6-8509-97eab9da0f3f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "68c0fbec-c4a3-4670-b931-a5e64a087682");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "d29ff325-3b9e-4334-ad7f-8a8a0268016a");

            migrationBuilder.DeleteData(
                table: "SellerDashboard",
                keyColumn: "SellerDashBoardId",
                keyValue: "d72664a5-406b-403f-a318-11aa79b0fb24");

            migrationBuilder.DeleteData(
                table: "SellerDashboard",
                keyColumn: "SellerDashBoardId",
                keyValue: "d76ba516-d518-40ef-b50e-ad9f405e6870");

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: "7e310437-f2c5-4dce-a9ef-3eceaae86259");

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: "bd47531f-af53-4a3c-b187-fb553a3c8292");

            migrationBuilder.DeleteData(
                table: "SellersOrders",
                keyColumn: "SellerOrdersId",
                keyValue: "3a24770a-35e5-4a5d-bf77-cfbda1ed0bf3");

            migrationBuilder.DeleteData(
                table: "SellersOrders",
                keyColumn: "SellerOrdersId",
                keyValue: "5200954e-2c71-449d-a755-9f5c9deed157");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: "2ad4d0bb-7022-4537-a235-05d1065bbd60");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: "9e7ee5dd-f59e-483b-9ba0-527bccdd0951");

            migrationBuilder.DropColumn(
                name: "ProductTypesProductTypeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
    }
}
