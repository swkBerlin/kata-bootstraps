using FluentAssertions;
using Kata;
using Xunit;

namespace Kata.XUnit.Tests
{
    public class HelloWorldTests
    {
        [Fact]
        public void HelloWorld_Should_SayHelloWorld()
        {
            // Arrange
            var sut = new HelloWorld();

            // Act
            var actual = sut.SayHelloWorld();

            // Assert
            actual.Should().Be("Oh oh ...");
        }
    }
}
