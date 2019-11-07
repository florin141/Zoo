using System;
using Microsoft.AspNetCore.Http;

namespace Zoo.Web.Areas.admin.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public IFormFile Picture { get; set; }
    }
}
