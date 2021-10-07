using Moq;
using Xunit;
using Kata;

namespace Kata.Tests
{
  //[TestFixture]
  public class Tests
  {
    private Mock<IDisplay> _displayMock;
    private GameScore _gameScore;

    public Tests()
    {
      _displayMock = new Mock<IDisplay>();
      _gameScore = new GameScore(_displayMock.Object);
    }
    [Fact]
    public void InitializeGameScore_ShouldBeLove()
    {
      _displayMock.Verify(x=>x.DisplayScore("Love - Love"), Times.Once);
    }
    [Fact]
    public void PlayerScores_ShouldCallDisplayScoreTwice()
    {
      _gameScore.PlayerScores();
      _displayMock.Verify(x => x.DisplayScore(It.IsAny<string>()), Times.Exactly(2));
    }

  }
}