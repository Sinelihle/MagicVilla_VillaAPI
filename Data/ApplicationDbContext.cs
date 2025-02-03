using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Newtonsoft.Json.Serialization;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber()
                {
                    VillaNo = 101,
                    SpecialDetails = "Oceanfront villa with private pool and exclusive butler service.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 102,
                    SpecialDetails = "Mountain-view villa with a cozy fireplace and outdoor jacuzzi.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 103,
                    SpecialDetails = "Luxury suite with a private rooftop garden and 360-degree city views.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 104,
                    SpecialDetails = "Secluded forest cabin villa with an indoor spa and meditation area.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 105,
                    SpecialDetails = "Beachside villa with direct access to the white sand beach and a hammock lounge.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new VillaNumber()
                {
                    VillaNo = 106,
                    SpecialDetails = "High-tech smart villa with automated lighting, voice-controlled climate, and premium entertainment setup.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Hotel>().HasData(

                new Hotel()
                {
                    Id = 1,
                    Name = "Grand Horizon Hotel",
                    Description = "A luxurious 5-star hotel offering world-class amenities and breathtaking city views.",
                    Address = "123 Skyline Avenue",
                    City = "Johannesburg",
                    Country = "South Africa",
                    ZipCode = "2001",
                    PhoneNumber = "+27 11 123 4567",
                    Email = "contact@grandhorizon.com",
                    WebsiteUrl = "https://www.grandhorizon.com",
                    CreatedDate = DateTime.Now
                },
                new Hotel()
                {
                    Id = 2,
                    Name = "Sunset Bay Resort",
                    Description = "A beachfront resort with stunning ocean views and private beach access.",
                    Address = "45 Beachfront Road",
                    City = "Cape Town",
                    Country = "South Africa",
                    ZipCode = "8000",
                    PhoneNumber = "+27 21 987 6543",
                    Email = "info@sunsetbay.com",
                    WebsiteUrl = "https://www.sunsetbay.com",
                    CreatedDate = DateTime.Now
                },
                new Hotel()
                {
                    Id = 3,
                    Name = "Mountain Lodge Retreat",
                    Description = "A peaceful mountain lodge surrounded by nature, ideal for relaxation and hiking.",
                    Address = "99 Alpine Way",
                    City = "Drakensberg",
                    Country = "South Africa",
                    ZipCode = "3257",
                    PhoneNumber = "+27 36 456 7890",
                    Email = "stay@mountainlodge.com",
                    WebsiteUrl = "https://www.mountainlodge.com",
                    CreatedDate = DateTime.Now
                },
                new Hotel()
                {
                    Id = 4,
                    Name = "Urban Escape Hotel",
                    Description = "A stylish and modern hotel in the heart of the city, perfect for business and leisure travelers.",
                    Address = "88 Main Street",
                    City = "Durban",
                    Country = "South Africa",
                    ZipCode = "4001",
                    PhoneNumber = "+27 31 765 4321",
                    Email = "bookings@urbanescape.com",
                    WebsiteUrl = "https://www.urbanescape.com",
                    CreatedDate = DateTime.Now
                },
                new Hotel()
                {
                    Id = 5,
                    Name = "The Royal Palm Hotel",
                    Description = "A luxury hotel offering elegant accommodations and premium services.",
                    Address = "12 Prestige Avenue",
                    City = "Pretoria",
                    Country = "South Africa",
                    ZipCode = "0028",
                    PhoneNumber = "+27 12 345 6789",
                    Email = "contact@royalpalm.com",
                    WebsiteUrl = "https://www.royalpalm.com",
                    CreatedDate = DateTime.Now
                },
                new Hotel()
                {
                    Id = 6,
                    Name = "Safari Lodge & Spa",
                    Description = "An exclusive safari lodge offering close encounters with wildlife and luxury accommodations.",
                    Address = "57 Savannah Lane",
                    City = "Kruger National Park",
                    Country = "South Africa",
                    ZipCode = "1350",
                    PhoneNumber = "+27 13 567 8901",
                    Email = "reservations@safarilodge.com",
                    WebsiteUrl = "https://www.safarilodge.com",
                    CreatedDate = DateTime.Now
                }
            );


            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    ImageUrl = "https://images.pexels.com/photos/28539583/pexels-photo-28539583/free-photo-of-majestic-mountain-peaks-at-sunrise.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Occupancy= 5,
                    Rate = 2000,
                    Sqft = 60,
                    Amenity= "",
                    CreatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Ocean Breeze Villa",
                    Details = "Experience the serenity of the ocean with breathtaking views and luxurious comfort. Perfect for a relaxing getaway.",
                    ImageUrl = "https://images.pexels.com/photos/1571460/pexels-photo-1571460.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Occupancy = 4,
                    Rate = 1800,
                    Sqft = 50,
                    Amenity = "Pool, Free Wi-Fi, Private Beach Access",
                    CreatedDate = DateTime.Now

                },
                new Villa()
                {
                    Id = 3,
                    Name = "Mountain Retreat Villa",
                    Details = "Nestled in the mountains, this villa offers a peaceful escape surrounded by nature. Ideal for adventurers and nature lovers.",
                    ImageUrl = "https://images.pexels.com/photos/6985016/pexels-photo-6985016.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Occupancy = 6,
                    Rate = 2200,
                    Sqft = 75,
                    Amenity = "Fireplace, Hiking Trails, Scenic Views",
                    CreatedDate = DateTime.Now

                },
                new Villa()
                {
                    Id = 4,
                    Name = "Luxury Desert Villa",
                    Details = "A stunning villa in the heart of the desert, combining modern luxury with timeless beauty. A unique experience awaits.",
                    ImageUrl = "https://images.pexels.com/photos/220067/pexels-photo-220067.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Occupancy = 3,
                    Rate = 2500,
                    Sqft = 45,
                    Amenity = "Infinity Pool, Spa Services, Private Patio",
                    CreatedDate = DateTime.Now

                },
                new Villa()
                {
                    Id = 5,
                    Name = "Tropical Paradise Villa",
                    Details = "A slice of paradise in the tropics. Enjoy vibrant greenery, exotic wildlife, and luxurious amenities.",
                    ImageUrl = "https://images.pexels.com/photos/260922/pexels-photo-260922.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Occupancy = 5,
                    Rate = 2100,
                    Sqft = 65,
                    Amenity = "Outdoor Shower, Hammock, BBQ Area",
                    CreatedDate = DateTime.Now

                },
                new Villa()
                {
                    Id = 6,
                    Name = "Countryside Haven",
                    Details = "Escape to the countryside and enjoy the charm of rustic living with modern comforts in this cozy villa.",
                    ImageUrl = "https://images.pexels.com/photos/1643389/pexels-photo-1643389.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    Occupancy = 4,
                    Rate = 1700,
                    Sqft = 55,
                    Amenity = "Garden, Fireplace, Board Games",
                    CreatedDate = DateTime.Now

                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
