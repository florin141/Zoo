using System;
using Microsoft.AspNetCore.Http.Internal;
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
                BirthDate = model.BirthDate,
                Picture = model.Picture.ToBase64String()
            };

            _employeeService.InsertEmployee(employee);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound();
            }

            var employeeDto = new EmployeeDto
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                Picture = null
            };
            

            return View(employeeDto);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeDto model)
        {
            var employeeFromDb = _employeeService.GetEmployeeById(model.Id);

            employeeFromDb.FirstName = model.FirstName;
            employeeFromDb.LastName = model.LastName;
            employeeFromDb.BirthDate = model.BirthDate;

            if (model.Picture != null)
            {
                employeeFromDb.Picture = model.Picture.ToBase64String();
            }

            _employeeService.UpdateEmployee(employeeFromDb);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            // TODO Add DeleteEmployeeById to get rid of the double trip to DB
            var employeeFromDb = _employeeService.GetEmployeeById(id);

            if (employeeFromDb == null)
            {
                return NotFound();
            }

            _employeeService.DeleteEmployee(employeeFromDb);

            return RedirectToAction("Index");
        }
    }
}
