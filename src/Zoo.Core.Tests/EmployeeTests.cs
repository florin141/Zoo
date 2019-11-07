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
                Picture = "/9j/4Q",
                BirthDate = DateTime.Parse("10/10/1992")
            };

            Assert.NotNull(employee);
            Assert.Equal("John", employee.FirstName);
            Assert.Equal("Deep", employee.LastName);
            Assert.Equal("/9j/4Q", employee.Picture);
            Assert.Equal(DateTime.Parse("10/10/1992"), employee.BirthDate);
        }
    }
}
