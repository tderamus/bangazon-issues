using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bangazon_issues.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPaymentTypeEnumName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypePayment",
                table: "PaymentTypes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: 1,
                column: "TypePayment",
                value: 4);

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "PaymentTypeId",
                keyValue: 2,
                column: "TypePayment",
                value: 9);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypePayment",
                table: "PaymentTypes");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2025, 3, 2, 15, 31, 17, 788, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2025, 3, 2, 15, 31, 17, 788, DateTimeKind.Local).AddTicks(5509));
        }
    }
}
