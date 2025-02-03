using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace MagicVilla_VillaAPI.Models
{
    public class Hotel
    {
        [Key]
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

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

    }
}
