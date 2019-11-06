using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zoo.Web.Areas.admin.Controllers
{
    public class HabitatsController : AdminControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
