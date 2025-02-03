using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class HotelMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedDate", "Description", "Email", "Name", "PhoneNumber", "UpdatedDate", "WebsiteUrl", "ZipCode" },
                values: new object[,]
                {
                    { 1, "123 Skyline Avenue", "Johannesburg", "South Africa", new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5929), "A luxurious 5-star hotel offering world-class amenities and breathtaking city views.", "contact@grandhorizon.com", "Grand Horizon Hotel", "+27 11 123 4567", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.grandhorizon.com", "2001" },
                    { 2, "45 Beachfront Road", "Cape Town", "South Africa", new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5955), "A beachfront resort with stunning ocean views and private beach access.", "info@sunsetbay.com", "Sunset Bay Resort", "+27 21 987 6543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.sunsetbay.com", "8000" },
                    { 3, "99 Alpine Way", "Drakensberg", "South Africa", new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5958), "A peaceful mountain lodge surrounded by nature, ideal for relaxation and hiking.", "stay@mountainlodge.com", "Mountain Lodge Retreat", "+27 36 456 7890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.mountainlodge.com", "3257" },
                    { 4, "88 Main Street", "Durban", "South Africa", new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5960), "A stylish and modern hotel in the heart of the city, perfect for business and leisure travelers.", "bookings@urbanescape.com", "Urban Escape Hotel", "+27 31 765 4321", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.urbanescape.com", "4001" },
                    { 5, "12 Prestige Avenue", "Pretoria", "South Africa", new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5962), "A luxury hotel offering elegant accommodations and premium services.", "contact@royalpalm.com", "The Royal Palm Hotel", "+27 12 345 6789", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.royalpalm.com", "0028" },
                    { 6, "57 Savannah Lane", "Kruger National Park", "South Africa", new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5965), "An exclusive safari lodge offering close encounters with wildlife and luxury accommodations.", "reservations@safarilodge.com", "Safari Lodge & Spa", "+27 13 567 8901", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.safarilodge.com", "1350" }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6582), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2025, 1, 27, 12, 40, 58, 203, DateTimeKind.Local).AddTicks(9774), "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 27, 12, 40, 58, 203, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 27, 12, 40, 58, 203, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 27, 12, 40, 58, 203, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 27, 12, 40, 58, 203, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2025, 1, 27, 12, 40, 58, 203, DateTimeKind.Local).AddTicks(9793));
        }
    }
}
