using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Zoo.Core.Domain;

namespace Zoo.Core.Tests
{
    public class AnimalTests
    {
        [Fact]
        public void ItExists()
        {
            var animal = new Animal
            {
                Id = 0,
                Name = "Lion",
                Description = "Lion description",
                HabitatId = 1,
                Habitat = new Habitat()
            };

            Assert.NotNull(animal);
            Assert.NotNull(animal.Habitat);
            Assert.Equal("Lion", animal.Name);
            Assert.Equal(1, animal.HabitatId);
            Assert.Equal("Lion description", animal.Description);
        }
    }
}
