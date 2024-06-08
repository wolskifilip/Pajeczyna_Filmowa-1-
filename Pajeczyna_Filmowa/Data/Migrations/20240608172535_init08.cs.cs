using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pajeczyna_Filmowa.Data.Migrations
{
    /// <inheritdoc />
    public partial class init08cs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "MovieId", "RatingNum" },
                values: new object[,]
                {
                    { 1, 1, 5.0 },
                    { 2, 1, 4.0 },
                    { 3, 1, 3.0 },
                    { 4, 1, 2.0 },
                    { 5, 1, 1.0 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7766));
        }
    }
}
