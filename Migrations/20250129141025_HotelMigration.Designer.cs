﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250129141025_HotelMigration")]
    partial class HotelMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WebsiteUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Skyline Avenue",
                            City = "Johannesburg",
                            Country = "South Africa",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5929),
                            Description = "A luxurious 5-star hotel offering world-class amenities and breathtaking city views.",
                            Email = "contact@grandhorizon.com",
                            Name = "Grand Horizon Hotel",
                            PhoneNumber = "+27 11 123 4567",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WebsiteUrl = "https://www.grandhorizon.com",
                            ZipCode = "2001"
                        },
                        new
                        {
                            Id = 2,
                            Address = "45 Beachfront Road",
                            City = "Cape Town",
                            Country = "South Africa",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5955),
                            Description = "A beachfront resort with stunning ocean views and private beach access.",
                            Email = "info@sunsetbay.com",
                            Name = "Sunset Bay Resort",
                            PhoneNumber = "+27 21 987 6543",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WebsiteUrl = "https://www.sunsetbay.com",
                            ZipCode = "8000"
                        },
                        new
                        {
                            Id = 3,
                            Address = "99 Alpine Way",
                            City = "Drakensberg",
                            Country = "South Africa",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5958),
                            Description = "A peaceful mountain lodge surrounded by nature, ideal for relaxation and hiking.",
                            Email = "stay@mountainlodge.com",
                            Name = "Mountain Lodge Retreat",
                            PhoneNumber = "+27 36 456 7890",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WebsiteUrl = "https://www.mountainlodge.com",
                            ZipCode = "3257"
                        },
                        new
                        {
                            Id = 4,
                            Address = "88 Main Street",
                            City = "Durban",
                            Country = "South Africa",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5960),
                            Description = "A stylish and modern hotel in the heart of the city, perfect for business and leisure travelers.",
                            Email = "bookings@urbanescape.com",
                            Name = "Urban Escape Hotel",
                            PhoneNumber = "+27 31 765 4321",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WebsiteUrl = "https://www.urbanescape.com",
                            ZipCode = "4001"
                        },
                        new
                        {
                            Id = 5,
                            Address = "12 Prestige Avenue",
                            City = "Pretoria",
                            Country = "South Africa",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5962),
                            Description = "A luxury hotel offering elegant accommodations and premium services.",
                            Email = "contact@royalpalm.com",
                            Name = "The Royal Palm Hotel",
                            PhoneNumber = "+27 12 345 6789",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WebsiteUrl = "https://www.royalpalm.com",
                            ZipCode = "0028"
                        },
                        new
                        {
                            Id = 6,
                            Address = "57 Savannah Lane",
                            City = "Kruger National Park",
                            Country = "South Africa",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(5965),
                            Description = "An exclusive safari lodge offering close encounters with wildlife and luxury accommodations.",
                            Email = "reservations@safarilodge.com",
                            Name = "Safari Lodge & Spa",
                            PhoneNumber = "+27 13 567 8901",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WebsiteUrl = "https://www.safarilodge.com",
                            ZipCode = "1350"
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6582),
                            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            ImageUrl = "https://images.pexels.com/photos/28539583/pexels-photo-28539583/free-photo-of-majestic-mountain-peaks-at-sunrise.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 2000.0,
                            Sqft = 60,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Pool, Free Wi-Fi, Private Beach Access",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6591),
                            Details = "Experience the serenity of the ocean with breathtaking views and luxurious comfort. Perfect for a relaxing getaway.",
                            ImageUrl = "https://images.pexels.com/photos/1571460/pexels-photo-1571460.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Ocean Breeze Villa",
                            Occupancy = 4,
                            Rate = 1800.0,
                            Sqft = 50,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Fireplace, Hiking Trails, Scenic Views",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6594),
                            Details = "Nestled in the mountains, this villa offers a peaceful escape surrounded by nature. Ideal for adventurers and nature lovers.",
                            ImageUrl = "https://images.pexels.com/photos/6985016/pexels-photo-6985016.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Mountain Retreat Villa",
                            Occupancy = 6,
                            Rate = 2200.0,
                            Sqft = 75,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Infinity Pool, Spa Services, Private Patio",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6596),
                            Details = "A stunning villa in the heart of the desert, combining modern luxury with timeless beauty. A unique experience awaits.",
                            ImageUrl = "https://images.pexels.com/photos/220067/pexels-photo-220067.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Luxury Desert Villa",
                            Occupancy = 3,
                            Rate = 2500.0,
                            Sqft = 45,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Outdoor Shower, Hammock, BBQ Area",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6597),
                            Details = "A slice of paradise in the tropics. Enjoy vibrant greenery, exotic wildlife, and luxurious amenities.",
                            ImageUrl = "https://images.pexels.com/photos/260922/pexels-photo-260922.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Tropical Paradise Villa",
                            Occupancy = 5,
                            Rate = 2100.0,
                            Sqft = 65,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Amenity = "Garden, Fireplace, Board Games",
                            CreatedDate = new DateTime(2025, 1, 29, 16, 10, 24, 506, DateTimeKind.Local).AddTicks(6599),
                            Details = "Escape to the countryside and enjoy the charm of rustic living with modern comforts in this cozy villa.",
                            ImageUrl = "https://images.pexels.com/photos/1643389/pexels-photo-1643389.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Countryside Haven",
                            Occupancy = 4,
                            Rate = 1700.0,
                            Sqft = 55,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
