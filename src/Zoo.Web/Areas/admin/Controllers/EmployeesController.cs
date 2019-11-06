using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zoo.Services.Employees;
using Zoo.Services.Habitats;
using Zoo.Web.Areas.admin.Models;

namespace Zoo.Web.Areas.admin.Controllers
{
    public class EmployeesController : AdminControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var emp = _employeeService.GetEmployees();

            return View(emp);
        }
    }
}
