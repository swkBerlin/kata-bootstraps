using Kata.Advanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Kata.MSTest.Tests.Advanced
{
    [TestClass]
    public class BusinessControllerTests
    {
        [TestMethod]
        public void BusinessController_Add_ShouldReturnTheAddedEntity()
        {
            // Arrange
            var expected = new BusinessEntity();
            var repoMock = new Mock<IBusinessEntityService>();
            repoMock.Setup(repo => repo.Store(It.IsAny<BusinessEntity>())).Returns(1664);
            repoMock.Setup(repo => repo.Get(1664)).Returns(expected);
            var sut = new BusinessController(repoMock.Object);

            // Act
            var actual = sut.Add(new BusinessEntity());

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
