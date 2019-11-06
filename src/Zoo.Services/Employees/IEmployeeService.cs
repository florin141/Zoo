using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Core.Domain;

namespace Zoo.Services.Employees
{
    public interface IEmployeeService
    {
        Employee GetEmployeeById(int id);

        IEnumerable<Employee> GetEmployees();

        void InsertEmployee(Employee employee);

        void InsertEmployees(IEnumerable<Employee> employees);

        void UpdateEmployee(Employee employee);

        void UpdateEmployees(IEnumerable<Employee> employees);

        void DeleteEmployee(Employee employee);

        void DeleteEmployees(IEnumerable<Employee> employees);
    }
}
