using System;
using Microsoft.AspNetCore.Mvc;
using Zoo.Core.Domain;
using Zoo.Services.Employees;
using Zoo.Web.Areas.admin.Models;
using Zoo.Web.Extensions;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeDto model)
        {
            var employee = new Employee
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                BirthDate = DateTime.Now,
                Picture = model.Picture.ToBase64String()
            };

            _employeeService.InsertEmployee(employee);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            _employeeService.DeleteEmployee(employee);

            return RedirectToAction("Index");
        }
    }
}
