using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Models.Dto
{
    public class HotelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }


        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string WebsiteUrl { get; set; }
    }
}
