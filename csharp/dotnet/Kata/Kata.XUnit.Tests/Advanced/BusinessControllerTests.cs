using FluentAssertions;
using Kata.Advanced;
using Kata.XUnit.Tests.AutoDataAttributes;
using NSubstitute;
using Ploeh.AutoFixture.Xunit2;
using Xunit;

namespace Kata.XUnit.Tests.Advanced
{
    public class BusinessControllerTests
    {
        // The AutoMoqData uses the AutoMoqCustomization to pass the object of repoMock as Parameter to the constructor of 
        // the sut. The [Frozen] make this mock instanciated as a Singleton within the unit test context, thus allowing us to
        // to setup the mock and verify it with minimum boilerplate
        [Theory, AutoConfiguredNSubstituteData]
        public void AutoFixture_ShouldBeAbleToAutoMock_DirectDependencies_WithNSubstitute(
            // Autofixture instanciates these for us
            [Frozen]IBusinessEntityService service,
            BusinessController sut,
            // this entity will have properties set with dummy values
            BusinessEntity expected)
        {
            // Arrange
            var entity = new BusinessEntity();
            service.Store(entity).Returns(expected.Id);
            service.Get(expected.Id).Returns(expected);

            // Act
            var actual = sut.Add(entity);

            // Assert
            actual.Should().Be(expected);
            service.Received(1).Store(entity);
            service.Received(1).Get(expected.Id);
        }
    }
}
