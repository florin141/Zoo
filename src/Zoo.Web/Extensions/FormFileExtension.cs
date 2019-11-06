using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
