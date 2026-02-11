using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;
using Ploeh.AutoFixture.Xunit2;

namespace Kata.XUnit.Tests.AutoDataAttributes
{
    /// <summary>
    /// This attribute will automock dependencies using NSubstitute
    /// </summary>
    public class AutoNSubstituteDataAttribute : AutoDataAttribute
    {
        public AutoNSubstituteDataAttribute()
            : base(new Fixture()
                .Customize(new AutoNSubstituteCustomization()))
        {
        }
    }
}
