using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bangazon_issues.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedOrderStatusEnumName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderState",
                table: "OrderStatus",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: 1,
                column: "OrderState",
                value: 0);

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "OrderStatusId",
                keyValue: 2,
                column: "OrderState",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2025, 3, 2, 15, 51, 56, 924, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2025, 3, 2, 15, 51, 56, 924, DateTimeKind.Local).AddTicks(5617));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderState",
                table: "OrderStatus");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2025, 3, 2, 15, 39, 15, 192, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2025, 3, 2, 15, 39, 15, 192, DateTimeKind.Local).AddTicks(1709));
        }
    }
}
