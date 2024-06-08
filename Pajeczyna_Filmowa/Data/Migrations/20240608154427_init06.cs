using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pajeczyna_Filmowa.Data.Migrations
{
    /// <inheritdoc />
    public partial class init06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "CreatedAt", "MovieId", "ReviewText" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2712), 1, "Fajny film" },
                    { 2, new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2717), 1, "Szkoda że taki krótki film pozdro" },
                    { 3, new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2721), 2, "Mogło być lepiej" },
                    { 4, new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2725), 3, "Niezatapialny statek XD" },
                    { 5, new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2729), 4, "Spider man Spider man ...." },
                    { 6, new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2733), 5, "Gdzie jest joker co to za batman bez jokera" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
