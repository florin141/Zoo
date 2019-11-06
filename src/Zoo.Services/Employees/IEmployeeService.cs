using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Core.Domain;

namespace Zoo.Services.Employees
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
    }
}
