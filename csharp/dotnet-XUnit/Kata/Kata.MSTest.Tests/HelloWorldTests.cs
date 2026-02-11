using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Kata.MSTest.Tests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void HelloWorld_Should_SayHelloWorld()
        {
            // Arrange
            var sut = new HelloWorld();

            // Act
            var actual = sut.SayHelloWorld();

            // Assert
            Assert.AreEqual("Oh oh ...", actual);
        }
    }
}
