using System;
using Xunit;
using Zoo.Core.Domain;

namespace Zoo.Core.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void ItExists()
        {
            var employee = new Employee
            {
                Id = 0,
                FirstName = "John",
                LastName = "Deep",
                BirthDate = DateTime.Parse("10/10/1992")
            };

            Assert.NotNull(employee);
            Assert.Equal("John", employee.FirstName);
            Assert.Equal("Deep", employee.LastName);
            Assert.Equal(DateTime.Parse("10/10/1992"), employee.BirthDate);
        }
    }
}
