using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Zoo.Services.Animals;
using Zoo.Services.Employees;
using Zoo.Services.Habitats;
using Zoo.Web.Areas.admin.Models;

namespace Zoo.Web.Areas.admin.Controllers
{
    public class DashboardController : AdminControllerBase
    {
        private readonly IHabitatService _habitatService;
        private readonly IEmployeeService _employeeService;
        private readonly IAnimalService _animalService;

        public DashboardController(IHabitatService habitatService, 
            IEmployeeService employeeService,
            IAnimalService animalService)
        {
            _habitatService = habitatService;
            _employeeService = employeeService;
            _animalService = animalService;
        }

        public IActionResult Index()
        {
            var model = new DashboardDto
            {
                Habitats = _habitatService.GetHabitats().Count(),
                Animals = _animalService.GetAnimals().Count(),
                Employees = _employeeService.GetEmployees().Count()
            };

            return View(model);
        }
    }
}