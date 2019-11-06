using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Zoo.Core.Domain;

namespace Zoo.Core.Tests
{
    public class HabitatTests
    {
        [Fact]
        public void ItExists()
        {
            var habitat = new Habitat
            {
                Id = 1,
                Name = "African savanna",
                Description = "Habitat description",
                Animals = new List<Animal>
                {
                    new Animal(),
                    new Animal()
                }
            };

            Assert.NotNull(habitat);
            Assert.Equal("African savanna", habitat.Name);
            Assert.Equal("Habitat description", habitat.Description);

            Assert.NotNull(habitat.Animals);
            Assert.Equal(2, habitat.Animals.Count);
        }
    }
}
