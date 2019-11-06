using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zoo.Services.Animals;
using Zoo.Services.Habitats;

namespace Zoo.Web.Controllers
{
    public class HabitatsController : Controller
    {
        private readonly IHabitatService _habitatService;
        private readonly IAnimalService _animalService;

        public HabitatsController(IHabitatService habitatService,
            IAnimalService animalService)
        {
            _habitatService = habitatService;
            _animalService = animalService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var habitats = _habitatService.GetHabitats();

            return View(habitats);
        }

        [HttpGet]
        public IActionResult Animals(int id)
        {
            var animals = _animalService.GetAnimalsByHabitatId(id);

            return View(animals);
        }
    }
}