using FluentAssertions;
using Xunit;

namespace Kata.Tests
{
    public class HelloWorldTests
    {
        [Fact]
        public void SayHelloWorld_ShouldReturnHelloWorld()
        {
            // Arrange
            var sut = new HelloWorld();
            const string expected = "Hello World!";
            // Act
            var actual = sut.SayHelloWorld();
            // Asseert
            actual.Should().Equals(expected);
        }
    }
}
