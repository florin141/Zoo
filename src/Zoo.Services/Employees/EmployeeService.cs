using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Core.Data;
using Zoo.Core.Domain;

namespace Zoo.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetAll();
        }
    }
}
