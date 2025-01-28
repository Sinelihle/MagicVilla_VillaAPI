using MagicVilla_VillaAPI.Models;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
