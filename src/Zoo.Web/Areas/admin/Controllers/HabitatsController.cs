using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Domain;
using Zoo.Services.Habitats;
using Zoo.Web.Areas.admin.Models;
using Zoo.Web.Extensions;

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
            var habitats = _habitatService.GetHabitats();

            return View(habitats);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HabitatDto model)
        {
            var habitat = new Habitat
            {
                Name = model.Name,
                Description = model.Description,
                Picture = model.Picture.ToBase64String(),
            };

            _habitatService.InsertHabitat(habitat);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var habitat = _habitatService.GetHabitatById(id);

            if (habitat == null)
            {
                return NotFound();
            }

            var habitatDto = new HabitatDto
            {
                Name = habitat.Name,
                Description = habitat.Description,
                Picture = null
            };

            return View(habitatDto);
        }

        [HttpPost]
        public IActionResult Edit(HabitatDto model)
        {
            var habitatFromDb = _habitatService.GetHabitatById(model.Id);

            habitatFromDb.Name = model.Name;
            habitatFromDb.Description = model.Description;

            if (model.Picture != null)
            {
                habitatFromDb.Picture = model.Picture.ToBase64String();
            }

            _habitatService.UpdateHabitat(habitatFromDb);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var habitatFromDb = _habitatService.GetHabitatById(id);

            if (habitatFromDb == null)
            {
                return NotFound();
            }

            _habitatService.DeleteHabitat(habitatFromDb);

            return RedirectToAction("Index");
        }
    }
}
