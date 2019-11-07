using Microsoft.AspNetCore.Mvc;
using Zoo.Services.Animals;

namespace Zoo.Web.Areas.admin.Controllers
{
    public class AnimalsController : AdminControllerBase
    {
        private readonly IAnimalService _animalService;

        public AnimalsController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        public IActionResult Index()
        {
            return View(_animalService.GetAnimals());
        }
    }
}
