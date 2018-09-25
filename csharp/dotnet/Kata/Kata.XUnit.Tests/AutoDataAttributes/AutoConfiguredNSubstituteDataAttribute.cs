using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;
using Ploeh.AutoFixture.Xunit2;

namespace Kata.XUnit.Tests.AutoDataAttributes
{
    /// <summary>
    /// This attributes will automock dependencies and fill properties
    /// of objects with dummy values
    /// </summary>
    public class AutoConfiguredNSubstituteDataAttribute : AutoDataAttribute
    {
        public AutoConfiguredNSubstituteDataAttribute()
            : base(new Fixture()
                .Customize(new AutoConfiguredNSubstituteCustomization()))
        {
        }
    }
}
