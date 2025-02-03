using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate" },
                values: new object[,]
                {
                    { 101, new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7614), "Oceanfront villa with private pool and exclusive butler service.", new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7627) },
                    { 102, new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7628), "Mountain-view villa with a cozy fireplace and outdoor jacuzzi.", new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7628) },
                    { 103, new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7630), "Luxury suite with a private rooftop garden and 360-degree city views.", new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7630) },
                    { 104, new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7631), "Secluded forest cabin villa with an indoor spa and meditation area.", new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7631) },
                    { 105, new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7632), "Beachside villa with direct access to the white sand beach and a hammock lounge.", new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7633) },
                    { 106, new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7633), "High-tech smart villa with automated lighting, voice-controlled climate, and premium entertainment setup.", new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7634) }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7797));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6599));
        }
    }
}
