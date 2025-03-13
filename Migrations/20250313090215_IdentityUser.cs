using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5277), new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5290), new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5292), new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5293), new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 105,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5295), new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 106,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5296), new DateTime(2025, 3, 13, 11, 2, 14, 94, DateTimeKind.Local).AddTicks(5296) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 2, 14, 96, DateTimeKind.Local).AddTicks(4946));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8411), new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8424), new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8425), new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8427), new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 105,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8428), new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 106,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8430), new DateTime(2025, 3, 13, 8, 43, 10, 655, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 8, 43, 10, 657, DateTimeKind.Local).AddTicks(8895));
        }
    }
}
