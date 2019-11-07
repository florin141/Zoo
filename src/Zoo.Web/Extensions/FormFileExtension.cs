using System;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Zoo.Web.Extensions
{
    public static class FormFileExtension
    {
        public static string ToBase64String(this IFormFile file)
        {
            using (var stream = new MemoryStream())
            {
                file.CopyTo(stream);

                return Convert.ToBase64String(stream.ToArray());
            }
        }
    }
}
