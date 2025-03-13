using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8350), new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8362), new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8364), new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8365), new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 105,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8366), new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 106,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8368), new DateTime(2025, 3, 13, 11, 9, 21, 193, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 13, 11, 9, 21, 195, DateTimeKind.Local).AddTicks(6932));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
