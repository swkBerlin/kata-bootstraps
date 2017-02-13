using FluentAssertions;
using Kata.Advanced;
using Kata.XUnit.Tests.AutoDataAttributes;
using Moq;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace Kata.XUnit.Tests.Advanced
{
    public class BusinessControllerTests
    {
        // The AutoMoqData uses the AutoMoqCustomization to pass the object of repoMock as Parameter to the constructor of 
        // the sut. The [Frozen] make this mock instanciated as a Singleton within the unit test context, thus allowing us to
        // to setup the mock and verify it with minimum boilerplate
        [Theory, AutoMoqData]
        public void AutoFixture_ShouldBeAbleToAutoMock_DirectDependencies_WithMoQ(
            // Autofixture instanciates these for us
            [Frozen]Mock<IBusinessEntityService> serviceMock,
            BusinessController sut)
        {
            // Arrange
            var expected = new BusinessEntity();
            serviceMock.Setup(service => service.Store(It.IsAny<BusinessEntity>())).Returns(1664);
            serviceMock.Setup(service => service.Get(1664)).Returns(expected);


            // Act
            var entity = new BusinessEntity();
            var actual = sut.Add(entity);

            // Assert
            actual.Should().Equals(expected);
            serviceMock.Verify(service => service.Store(entity), Times.Once());
            serviceMock.Verify(service => service.Get(1664), Times.Once());
        }
    }
}
