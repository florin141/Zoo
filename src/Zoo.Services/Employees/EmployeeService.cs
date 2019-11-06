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

        public virtual void DeleteEmployee(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));

            _employeeRepository.Delete(employee);
        }

        public void DeleteEmployees(IEnumerable<Employee> employees)
        {
            if (employees == null) throw new ArgumentNullException(nameof(employees));

            _employeeRepository.Update(employees);
        }

        public Employee GetEmployeeById(int id)
        {
            if (id == 0) return null;

            return _employeeRepository.GetById(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public void InsertEmployee(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));

            _employeeRepository.Insert(employee);
        }

        public void InsertEmployees(IEnumerable<Employee> employees)
        {
            if (employees == null) throw new ArgumentNullException(nameof(employees));

            _employeeRepository.Insert(employees);
        }

        public void UpdateEmployee(Employee employee)
        {
            if (employee == null) throw new ArgumentNullException(nameof(employee));

            _employeeRepository.Update(employee);
        }

        public void UpdateEmployees(IEnumerable<Employee> employees)
        {
            if (employees == null) throw new ArgumentNullException(nameof(employees));

            _employeeRepository.Update(employees);
        }
    }
}
