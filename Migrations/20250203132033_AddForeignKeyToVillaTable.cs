using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyToVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8770), new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8780), 0 });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8782), new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8782), 0 });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8784), new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8784), 0 });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8785), new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8786), 0 });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 105,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8786), new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8787), 0 });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 106,
                columns: new[] { "CreatedDate", "UpdatedDate", "VillaID" },
                values: new object[] { new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8789), new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8790), 0 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 3, 15, 20, 32, 430, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers");

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

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7614), new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7628), new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7630), new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 104,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7631), new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 105,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7632), new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 106,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7633), new DateTime(2025, 1, 30, 11, 3, 25, 360, DateTimeKind.Local).AddTicks(7634) });

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
    }
}
