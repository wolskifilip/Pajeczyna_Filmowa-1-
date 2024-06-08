using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pajeczyna_Filmowa.Data.Migrations
{
    /// <inheritdoc />
    public partial class init13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 48, 41, 707, DateTimeKind.Local).AddTicks(1229), "3d6f5732-111a-4546-ae19-7b9ae85e3159" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 48, 41, 707, DateTimeKind.Local).AddTicks(1236), "3d6f5732-111a-4546-ae19-7b9ae85e3159" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 48, 41, 707, DateTimeKind.Local).AddTicks(1240), "3d6f5732-111a-4546-ae19-7b9ae85e3159" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 48, 41, 707, DateTimeKind.Local).AddTicks(1244), "3d6f5732-111a-4546-ae19-7b9ae85e3159" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 48, 41, 707, DateTimeKind.Local).AddTicks(1248), "3d6f5732-111a-4546-ae19-7b9ae85e3159" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 22, 48, 41, 707, DateTimeKind.Local).AddTicks(1252), "3d6f5732-111a-4546-ae19-7b9ae85e3159" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 30, 23, 407, DateTimeKind.Local).AddTicks(6722), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 30, 23, 407, DateTimeKind.Local).AddTicks(6727), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 30, 23, 407, DateTimeKind.Local).AddTicks(6731), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 30, 23, 407, DateTimeKind.Local).AddTicks(6734), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 30, 23, 407, DateTimeKind.Local).AddTicks(6738), null });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UserId" },
                values: new object[] { new DateTime(2024, 6, 8, 19, 30, 23, 407, DateTimeKind.Local).AddTicks(6742), null });
        }
    }
}
