using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pajeczyna_Filmowa.Data.Migrations
{
    /// <inheritdoc />
    public partial class init09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 26, 46, 154, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 26, 46, 154, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 26, 46, 154, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 26, 46, 154, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 26, 46, 154, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 26, 46, 154, DateTimeKind.Local).AddTicks(4419));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 25, 34, 660, DateTimeKind.Local).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 25, 34, 660, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 25, 34, 660, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 25, 34, 660, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 25, 34, 660, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 19, 25, 34, 660, DateTimeKind.Local).AddTicks(7432));
        }
    }
}
