using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "\"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "https://images.pexels.com/photos/28539583/pexels-photo-28539583/free-photo-of-majestic-mountain-peaks-at-sunrise.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Royal Villa", 5, 2000.0, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Pool, Free Wi-Fi, Private Beach Access", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Experience the serenity of the ocean with breathtaking views and luxurious comfort. Perfect for a relaxing getaway.", "https://images.pexels.com/photos/1571460/pexels-photo-1571460.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Ocean Breeze Villa", 4, 1800.0, 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Fireplace, Hiking Trails, Scenic Views", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nestled in the mountains, this villa offers a peaceful escape surrounded by nature. Ideal for adventurers and nature lovers.", "https://images.pexels.com/photos/6985016/pexels-photo-6985016.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Mountain Retreat Villa", 6, 2200.0, 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Infinity Pool, Spa Services, Private Patio", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A stunning villa in the heart of the desert, combining modern luxury with timeless beauty. A unique experience awaits.", "https://images.pexels.com/photos/220067/pexels-photo-220067.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Luxury Desert Villa", 3, 2500.0, 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Outdoor Shower, Hammock, BBQ Area", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A slice of paradise in the tropics. Enjoy vibrant greenery, exotic wildlife, and luxurious amenities.", "https://images.pexels.com/photos/260922/pexels-photo-260922.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Tropical Paradise Villa", 5, 2100.0, 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Garden, Fireplace, Board Games", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escape to the countryside and enjoy the charm of rustic living with modern comforts in this cozy villa.", "https://images.pexels.com/photos/1643389/pexels-photo-1643389.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Countryside Haven", 4, 1700.0, 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
