using System;
using Xunit;
using GridLogic;

namespace GridTests
{
    public class GridTests
    {
        [Fact]
        public void TestCtor()
        {
            var grid = new Grid(1000, 1000);
            Assert.Equal(1000, grid.Width);
            Assert.Equal(1000, grid.Height);
            Assert.Equal(0, grid.HowManyLightsAreOn());
        }


        [Theory]
        [InlineData(0, 0, 0, 0, 1)]
        [InlineData(0, 0, 999, 999, 1000000)]
        [InlineData(0, 0, 999, 0, 1000)]
        [InlineData(499, 499, 500, 500, 4)]
        public void TestTurnOn(int x1, int y1, int x2, int y2, int expected)
        {
            var grid = new Grid(1000, 1000);
            Tuple<int, int> startPosition = new(x1, y1), endPosition = new(x2, y2);
            grid.TurnOn(startPosition, endPosition);
            Assert.Equal(expected, grid.HowManyLightsAreOn());
        }

        [Theory]
        [InlineData(0, 0, 0, 0, 1)]
        [InlineData(0, 0, 999, 999, 1000000)]
        [InlineData(0, 0, 999, 0, 1000)]
        [InlineData(499, 499, 500, 500, 4)]
        public void TestTurnOff(int x1, int y1, int x2, int y2, int expected)
        {
            var grid = new Grid(1000, 1000);
            Tuple<int, int> startPosition = new(x1, y1),
                endPosition = new(x2, y2),
                firstPosition = new(0, 0),
                lastPosition = new(999, 999);

            grid.TurnOn(firstPosition, lastPosition);
            grid.TurnOff(startPosition, endPosition);
            Assert.Equal(1000000 - expected, grid.HowManyLightsAreOn());
        }

        [Theory]
        [InlineData(0, 0, 999, 999, 1000000)]
        [InlineData(0, 0, 999, 0, 1000)]
        [InlineData(499, 499, 500, 500, 4)]
        [InlineData(0, 0, 0, 0, 1)]
        public void TestToggle(int x1, int y1, int x2, int y2, int expected)
        {
            var grid = new Grid(1000, 1000);
            Tuple<int, int> startPosition = new(x1, y1), endPosition = new(x2, y2), firstPosition = new(0, 0), lastPosition = new(999, 999);
            grid.Toggle(startPosition, endPosition);
            Assert.Equal(expected, grid.HowManyLightsAreOn());

            grid.Toggle(firstPosition, lastPosition);
            Assert.Equal(1000000 - expected, grid.HowManyLightsAreOn());
        }

        // exactly same as TestTurnOn
        [Theory]
        [InlineData(0, 0, 999, 999, 1000000)]
        [InlineData(0, 0, 999, 0, 1000)]
        [InlineData(499, 499, 500, 500, 4)]
        [InlineData(0, 0, 0, 0, 1)]
        public void TestHowManyLightsAreOn(int x1, int y1, int x2, int y2, int expected)
        {
            var grid = new Grid(1000, 1000);
            Tuple<int, int> startPosition = new(x1, y1), endPosition = new(x2, y2);
            grid.TurnOn(startPosition, endPosition);
            Assert.Equal(expected, grid.HowManyLightsAreOn());
        }
    }
}