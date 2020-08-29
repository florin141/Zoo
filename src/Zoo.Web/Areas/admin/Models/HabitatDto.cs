using Microsoft.AspNetCore.Http;

namespace Zoo.Web.Areas.admin.Models
{
    public class HabitatDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IFormFile Picture { get; set; }
    }
}
