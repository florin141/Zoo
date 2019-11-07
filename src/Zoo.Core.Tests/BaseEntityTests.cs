using Xunit;
using Zoo.Core.Domain;

namespace Zoo.Core.Tests
{
    public class BaseEntityTests
    {
        [Fact]
        public void ItHasIdProperty()
        {
            var entity = new Animal();

            Assert.Equal(0, entity.Id);
        }
    }
}
