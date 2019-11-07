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
                Id = 1,
                Name = "Lion",
                Description = "Lion description",
                Picture = "/9j/4Q",
                HabitatId = 1,
                Habitat = new Habitat()
            };

            Assert.NotNull(animal);
            Assert.NotNull(animal.Habitat);
            Assert.Equal("Lion", animal.Name);
            Assert.Equal("/9j/4Q", animal.Picture);
            Assert.Equal(1, animal.HabitatId);
            Assert.Equal("Lion description", animal.Description);
        }
    }
}
