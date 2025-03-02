using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bangazon_issues.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAcctTypeEnumName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccountTypeEnum",
                table: "AccountType",
                newName: "TypeAcct");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeAcct",
                table: "AccountType",
                newName: "AccountTypeEnum");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 1,
                column: "PaymentDate",
                value: new DateTime(2025, 3, 2, 15, 23, 47, 709, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrdersId",
                keyValue: 2,
                column: "PaymentDate",
                value: new DateTime(2025, 3, 2, 15, 23, 47, 709, DateTimeKind.Local).AddTicks(4660));
        }
    }
}
