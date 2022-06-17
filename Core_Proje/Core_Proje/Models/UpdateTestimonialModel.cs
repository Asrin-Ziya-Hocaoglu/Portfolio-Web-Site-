using Microsoft.AspNetCore.Http;

namespace Core_Proje.Models
{
    public class UpdateTestimonialModel
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Profession { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Picture { get; set; }

    }
}
