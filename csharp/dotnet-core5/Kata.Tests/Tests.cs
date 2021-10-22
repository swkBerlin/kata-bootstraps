using System.Collections.Generic;
using System.Linq;
using Moq;
using Xunit;
using FluentAssertions;
using FluentValidation.Validators;

namespace Kata.Tests
{
  public class Tests
  {
    private readonly Mock<IDisplay> _displayMock;
    private readonly GameScore _gameScore;

    private enum Player
    {
      One = 1,
      Two = 2
    };

    public Tests()
    {
      _displayMock = new Mock<IDisplay>();
      _gameScore = new GameScore(_displayMock.Object);
    }

    [Fact]
    public void InitializeGameScore_ShouldBeLove()
    {
      _displayMock.Verify(x => x.DisplayScore($"{GameScore.Love} - {GameScore.Love}"), Times.Once);
    }

    [Fact]
    public void PlayerScores_ShouldCallDisplayScoreTwice()
    {
      SimulateGame(Player.One);
      _displayMock.Verify(x => x.DisplayScore(It.IsAny<string>()), Times.Exactly(2));
    }

    [Fact]
    public void PlayerOneScoresOnce_ShouldBe15Love()
    {
      SimulateGame(Player.One);
      _displayMock.Verify(x => x.DisplayScore($"{GameScore.Fifteen} - {GameScore.Love}"), Times.Once);
    }

    [Fact]
    public void PlayerOneScoresTwice_ShouldBe30Love()
    {
      SimulateGame(Player.One, Player.One);
      _displayMock.Verify(x => x.DisplayScore($"{GameScore.Thirty} - {GameScore.Love}"), Times.Once);
    }

    [Fact]
    public void PlayerTwoScoresOnce_ShouldBeLove15()
    {
      SimulateGame(Player.Two);
      _displayMock.Verify(x => x.DisplayScore($"{GameScore.Love} - {GameScore.Fifteen}"), Times.Once);
    }

    [Fact]
    public void PlayerTwoScoresTwice_ShouldBeLove30()
    {
      SimulateGame(Player.Two, Player.Two);
      _displayMock.Verify(x => x.DisplayScore($"{GameScore.Love} - {GameScore.Thirty}"), Times.Once);
    }

    [Fact]
    public void PlayerOneScoresOnce_PlayerTwoScoresOnce_ShouldBeLove30()
    {
      SimulateGame(Player.One, Player.Two);
      _displayMock.Verify(x => x.DisplayScore($"{GameScore.Fifteen} - {GameScore.Fifteen}"), Times.Once);
    }
    
    private void SimulateGame(params Player[] playerScores)
    {
      foreach (Player player in playerScores)
      {
        if (player == Player.One)
        {
          _gameScore.PlayerOneScores();
        }
        else if( player == Player.Two)
        {
          _gameScore.PlayerTwoScores();
        }
      }
    }
  }
}