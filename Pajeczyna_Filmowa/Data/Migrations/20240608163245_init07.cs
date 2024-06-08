using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pajeczyna_Filmowa.Data.Migrations
{
    /// <inheritdoc />
    public partial class init07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Review",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7747), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7751), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7755), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7759), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7762), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 18, 32, 44, 588, DateTimeKind.Local).AddTicks(7766), null });

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserId",
                table: "Review",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_UserId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_UserId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Review");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 8, 17, 44, 26, 760, DateTimeKind.Local).AddTicks(2733));
        }
    }
}
