using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zoo.Services.Habitats;

namespace Zoo.Web.Areas.admin.Controllers
{
    public class HabitatsController : AdminControllerBase
    {
        private readonly IHabitatService _habitatService;

        public HabitatsController(IHabitatService habitatService)
        {
            _habitatService = habitatService;
        }

        public IActionResult Index()
        {
            return View(_habitatService.GetHabitats());
        }
    }
}
