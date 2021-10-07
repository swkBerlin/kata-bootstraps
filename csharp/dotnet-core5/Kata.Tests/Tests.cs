using FluentAssertions;
using NUnit.Framework;

namespace Kata.Tests
{
  public class Tests
  {
    [Test]
    public void SayHelloWorld_ShouldReturnHelloWorld()
    {
      // Given
      var sut = string.Empty;
      // When
      sut = sut.Insert(0, "foo");
      // Then
      sut.Should().Be("bar");
    }
  }
}