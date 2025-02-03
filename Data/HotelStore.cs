using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class HotelStore
    {
        public static List<HotelDTO> hotelList = new List<HotelDTO>
        {
            new HotelDTO
            {
                Id = 1,
                Name = "Sunset Resort",
                Description = "A beautiful beachfront resort with breathtaking views.",
                Address = "12 Ocean Drive",
                City = "Cape Town",
                Country = "South Africa",
                ZipCode = "8005",
                PhoneNumber = "+27 21 555 1234",
                Email = "contact@sunsetresort.com",
                WebsiteUrl = "https://sunsetresort.com"
            },
            new HotelDTO
            {
                Id = 2,
                Name = "Skyline Hotel",
                Description = "A modern hotel located in the heart of the city.",
                Address = "89 Downtown Street",
                City = "Johannesburg",
                Country = "South Africa",
                ZipCode = "2001",
                PhoneNumber = "+27 11 444 5678",
                Email = "info@skylinehotel.com",
                WebsiteUrl = "https://skylinehotel.com"
            },
            new HotelDTO
            {
                Id = 3,
                Name = "Mountain Lodge",
                Description = "A cozy lodge surrounded by scenic mountain views.",
                Address = "5 Alpine Road",
                City = "Drakensberg",
                Country = "South Africa",
                ZipCode = "3257",
                PhoneNumber = "+27 33 789 4567",
                Email = "hello@mountainlodge.com",
                WebsiteUrl = "https://mountainlodge.com"
            },
            new HotelDTO
            {
                Id = 4,
                Name = "Lakeside Inn",
                Description = "A peaceful retreat by the lake, perfect for relaxation.",
                Address = "77 Lakeview Road",
                City = "Knysna",
                Country = "South Africa",
                ZipCode = "6570",
                PhoneNumber = "+27 44 321 9876",
                Email = "reservations@lakesideinn.com",
                WebsiteUrl = "https://lakesideinn.com"
            },
            new HotelDTO
            {
                Id = 5,
                Name = "Royal Heritage Hotel",
                Description = "A historic hotel offering luxury and comfort.",
                Address = "1 Heritage Lane",
                City = "Pretoria",
                Country = "South Africa",
                ZipCode = "0002",
                PhoneNumber = "+27 12 765 4321",
                Email = "stay@royalheritage.com",
                WebsiteUrl = "https://royalheritage.com"
            }
        };
    }
}
