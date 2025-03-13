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
    [Migration("20250311124630_adduserToDb")]
    partial class adduserToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Dto.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaID")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaNumbers");

                    b.HasData(
                        new
                        {
                            VillaNo = 101,
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2067),
                            SpecialDetails = "Oceanfront villa with private pool and exclusive butler service.",
                            UpdatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2077),
                            VillaID = 0
                        },
                        new
                        {
                            VillaNo = 102,
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2078),
                            SpecialDetails = "Mountain-view villa with a cozy fireplace and outdoor jacuzzi.",
                            UpdatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2079),
                            VillaID = 0
                        },
                        new
                        {
                            VillaNo = 103,
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2080),
                            SpecialDetails = "Luxury suite with a private rooftop garden and 360-degree city views.",
                            UpdatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2081),
                            VillaID = 0
                        },
                        new
                        {
                            VillaNo = 104,
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2082),
                            SpecialDetails = "Secluded forest cabin villa with an indoor spa and meditation area.",
                            UpdatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2082),
                            VillaID = 0
                        },
                        new
                        {
                            VillaNo = 105,
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2083),
                            SpecialDetails = "Beachside villa with direct access to the white sand beach and a hammock lounge.",
                            UpdatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2084),
                            VillaID = 0
                        },
                        new
                        {
                            VillaNo = 106,
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2085),
                            SpecialDetails = "High-tech smart villa with automated lighting, voice-controlled climate, and premium entertainment setup.",
                            UpdatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 368, DateTimeKind.Local).AddTicks(2085),
                            VillaID = 0
                        });
                });

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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3698),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3704),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3706),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3708),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3709),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3711),
                            Description = "An exclusive safari lodge offering close encounters with wildlife and luxury accommodations.",
                            Email = "reservations@safarilodge.com",
                            Name = "Safari Lodge & Spa",
                            PhoneNumber = "+27 13 567 8901",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            WebsiteUrl = "https://www.safarilodge.com",
                            ZipCode = "1350"
                        });
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3750),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3752),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3754),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3756),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3757),
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
                            CreatedDate = new DateTime(2025, 3, 11, 14, 46, 28, 370, DateTimeKind.Local).AddTicks(3759),
                            Details = "Escape to the countryside and enjoy the charm of rustic living with modern comforts in this cozy villa.",
                            ImageUrl = "https://images.pexels.com/photos/1643389/pexels-photo-1643389.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            Name = "Countryside Haven",
                            Occupancy = 4,
                            Rate = 1700.0,
                            Sqft = 55,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Dto.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MagicVilla_VillaAPI.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MagicVilla_VillaAPI.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
