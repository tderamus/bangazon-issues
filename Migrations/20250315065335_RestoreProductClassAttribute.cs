using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bangazon_issues.Migrations
{
    /// <inheritdoc />
    public partial class RestoreProductClassAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "018465ba-c6df-4d4c-9d57-2c7974b57a86", 2 },
                    { "ba775162-12ca-4f33-830c-fb968ccba1ef", 1 }
                });

            migrationBuilder.InsertData(
                table: "CustomersOrders",
                columns: new[] { "CustomerOrderId", "CustomerUid", "OrdersId", "SellerId" },
                values: new object[,]
                {
                    { "6fd1233d-5161-45d0-a3dd-ba693974ce17", "2", null, null },
                    { "c5115502-5842-4612-aabc-f156e79cbad6", "1", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "OrderStatusId", "OrderState" },
                values: new object[,]
                {
                    { "9ab9a929-4919-4e21-be30-23918f21d22d", 0 },
                    { "d51bfecc-d1a3-4c19-a5a1-5b419d1d88dd", 2 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrdersId", "CustomerUid", "IsFullfilled", "OrderDate", "OrderStatusId", "PaymentDate", "PaymentId", "ProductId", "Quantity", "SellerId", "TotalPrice" },
                values: new object[,]
                {
                    { "5d25e23d-8d24-48cd-bdb4-e41add557c06", null, false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 15, 1, 53, 34, 971, DateTimeKind.Local).AddTicks(4137), null, null, 10, null, 450m },
                    { "60b16649-6c08-439c-9acd-d7033df1e145", null, true, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 3, 15, 1, 53, 34, 971, DateTimeKind.Local).AddTicks(4178), null, null, 5, null, 350m }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "PaymentTypeId", "TypePayment" },
                values: new object[,]
                {
                    { "6a6ce624-06cd-4ce0-98ff-d94d3e927262", 9 },
                    { "a62f90ed-e1f7-4588-9c0b-9e1480234ba8", 4 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "AccountNumber", "Amount", "CustomerUid", "PaymentDate", "PaymentTypesPaymentTypeId", "SellerId" },
                values: new object[,]
                {
                    { "2f258a5d-c960-4abd-b97e-763b0247df65", "0987654321", 0m, null, new DateTime(2025, 3, 15, 6, 53, 34, 971, DateTimeKind.Utc).AddTicks(4218), null, null },
                    { "b7e5a1af-677e-48cc-8ff4-d652f9c48fdd", "1234567890", 0m, null, new DateTime(2025, 3, 15, 6, 53, 34, 971, DateTimeKind.Utc).AddTicks(4216), null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "ProductTypeId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { "0be375b0-2eeb-49bc-97a4-29e58cd79364", "Gadgets are cooler", "", "Gadgets" },
                    { "6b3549db-038d-4e72-a4be-f550d8ad251f", "Widgets are cool", "", "Widgets" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "DateAdded", "Description", "ImageUrl", "IsAvailable", "Name", "Price", "ProductTypeId", "Quantity", "SellerUid" },
                values: new object[,]
                {
                    { "f7022167-28e2-4edc-b86b-c645a91dbd01", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A widget that does stuff", null, false, "Widget", 9.99m, 1, 100, "1" },
                    { "ff49305c-24ff-45bd-9063-5fd81bc814c1", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A gadget that does stuff", null, false, "Gadget", 19.99m, 2, 50, "2" }
                });

            migrationBuilder.InsertData(
                table: "SellerDashboard",
                columns: new[] { "SellerDashBoardId", "SellerId", "TotalOrders", "TotalRevenue" },
                values: new object[,]
                {
                    { "b2407a2b-6dad-41cb-a0d3-548230121c60", null, 1, 19.99m },
                    { "f3090c5c-2ca0-410a-99c5-ad089674602a", null, 2, 19.98m }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "AccountTypeId", "City", "Email", "FirstName", "LastName", "PhoneNumber", "PostalCode", "State" },
                values: new object[,]
                {
                    { "4115e821-1367-450f-a195-dacb5c770524", null, "Decatur", "seller@email.com", "Jane", "Doe", "555-555-5555", "32323", "Georgia" },
                    { "7f55916a-ed1a-4874-98ca-7a9225a5324f", null, "Birmingham", "jsmith@jsmith.com", "John", "Smith", "256-555-5555", "35203", "Alabama" }
                });

            migrationBuilder.InsertData(
                table: "SellersOrders",
                columns: new[] { "SellerOrdersId", "OrdersId", "SellersSellerId" },
                values: new object[,]
                {
                    { "7cd762b4-1879-409f-b13e-dc299c10fc0d", null, null },
                    { "90031ceb-5dce-40fd-ba80-704118c67aae", null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemsId", "OrdersId", "ProductsProductId", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { "297b16dc-b034-4ab5-925a-b489edc408d2", "60b16649-6c08-439c-9acd-d7033df1e145", null, 1, 35m },
                    { "d1657f95-d8bc-46d9-ae0d-4229167be1ef", "5d25e23d-8d24-48cd-bdb4-e41add557c06", null, 2, 45m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "AccountTypeId",
                keyValue: "018465ba-c6df-4d4c-9d57-2c7974b57a86");

            migrationBuilder.DeleteData(
                table: "AccountType",
                keyColumn: "AccountTypeId",
                keyValue: "ba775162-12ca-4f33-830c-fb968ccba1ef");

            migrationBuilder.DeleteData(
                table: "CustomersOrders",
                keyColumn: "CustomerOrderId",
                keyValue: "6fd1233d-5161-45d0-a3dd-ba693974ce17");

            migrationBuilder.DeleteData(
                table: "CustomersOrders",
                keyColumn: "CustomerOrderId",
                keyValue: "c5115502-5842-4612-aabc-f156e79cbad6");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: "297b16dc-b034-4ab5-925a-b489edc408d2");

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemsId",
                keyValue: "d1657f95-d8bc-46d9-ae0d-4229167be1ef");

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: "9ab9a929-4919-4e21-be30-23918f21d22d");

            migrationBuilder.DeleteData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: "d51bfecc-d1a3-4c19-a5a1-5b419d1d88dd");

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: "6a6ce624-06cd-4ce0-98ff-d94d3e927262");

            migrationBuilder.DeleteData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: "a62f90ed-e1f7-4588-9c0b-9e1480234ba8");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "2f258a5d-c960-4abd-b97e-763b0247df65");

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: "b7e5a1af-677e-48cc-8ff4-d652f9c48fdd");

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: "0be375b0-2eeb-49bc-97a4-29e58cd79364");

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "ProductTypeId",
                keyValue: "6b3549db-038d-4e72-a4be-f550d8ad251f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "f7022167-28e2-4edc-b86b-c645a91dbd01");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "ff49305c-24ff-45bd-9063-5fd81bc814c1");

            migrationBuilder.DeleteData(
                table: "SellerDashboard",
                keyColumn: "SellerDashBoardId",
                keyValue: "b2407a2b-6dad-41cb-a0d3-548230121c60");

            migrationBuilder.DeleteData(
                table: "SellerDashboard",
                keyColumn: "SellerDashBoardId",
                keyValue: "f3090c5c-2ca0-410a-99c5-ad089674602a");

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: "4115e821-1367-450f-a195-dacb5c770524");

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "SellerId",
                keyValue: "7f55916a-ed1a-4874-98ca-7a9225a5324f");

            migrationBuilder.DeleteData(
                table: "SellersOrders",
                keyColumn: "SellerOrdersId",
                keyValue: "7cd762b4-1879-409f-b13e-dc299c10fc0d");

            migrationBuilder.DeleteData(
                table: "SellersOrders",
                keyColumn: "SellerOrdersId",
                keyValue: "90031ceb-5dce-40fd-ba80-704118c67aae");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: "5d25e23d-8d24-48cd-bdb4-e41add557c06");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: "60b16649-6c08-439c-9acd-d7033df1e145");

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
    }
}
