using FluentAssertions;
using Kata.Advanced;
using NSubstitute;
using Xunit;

namespace Kata.Tests.Advanced
{
    public class BusinessControllerTests
    {
        [Fact]
        public void BusinessControllerAdd_ShouldStoreEntityUsingIBusinessEntityService()
        {
            // Arrange
            var service = Substitute.For<IBusinessEntityService>();
            var sut = new BusinessController(service);
            var entityToAdd = new BusinessEntity();
            var expected = new BusinessEntity {Id = 1664};
            // Setup mocks
            service.Store(entityToAdd).Returns(expected.Id);
            service.Get(expected.Id).Returns(expected);

            // Act
            var actual = sut.Add(entityToAdd);

            // Assert
            actual.Should().Be(expected);
            service.Received(1).Store(entityToAdd);
            service.Received(1).Get(expected.Id);
        }
    }
}