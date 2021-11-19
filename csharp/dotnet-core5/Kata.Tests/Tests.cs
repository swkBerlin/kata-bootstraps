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
    private readonly Mock<IDisplay> displayMock;
    private readonly GameScore gameScore;

    private enum Player
    {
      One = 1,
      Two = 2
    };
    
    /*
     *  Cursor parking
     */

    public Tests()
    {
      displayMock = new Mock<IDisplay>();
      gameScore = new GameScore(displayMock.Object);
    }

    #region UnitOfWork_StateUnderTest_ExpectedBehavior

    [Fact]
    public void GameScore_Construct_InvokesDisplayScoreWithLoveLove()
    {
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Love} - {GameScore.Love}"), Times.Once);
    }

    [Fact]
    public void GameScore_PlayerOneScoresOnce_InvokesDisplayScoreTwice()
    {
      SimulateGame(Player.One);
      displayMock.Verify(x => x.DisplayScore(It.IsAny<string>()), Times.Exactly(2));
    }

    [Fact]
    public void GameScore_PlayerOneScoresOnce_InvokesDisplayScoreWith15LoveOnce()
    {
      SimulateGame(Player.One);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Fifteen} - {GameScore.Love}"), Times.Once);
    }

    #endregion

    #region Given_Preconditions_When_StateUnderTest_Then_ExpectedBehavior

    [Fact]
    public void Given_GameScore_When_PlayerOneScoresTwice_Then_DisplayScoreInvokedWith30Love()
    {
      SimulateGame(Player.One, Player.One);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Thirty} - {GameScore.Love}"), Times.Once);
    }

    [Fact]
    public void Given_GameScore_When_PlayerTwoScoresOnce_Then_DisplayScoreInvokedWithLove15()
    {
      SimulateGame(Player.Two);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Love} - {GameScore.Fifteen}"), Times.Once);
    }

    [Fact]
    public void Given_GameScore_When_PlayerTwoScoresTwice_Then_DisplayScoreInvokedWithLove30()
    {
      SimulateGame(Player.Two, Player.Two);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Love} - {GameScore.Thirty}"), Times.Once);
    }

    [Fact]
    public void Given_GameScore_When_PlayerOneScoresFourTimes_Then_DisplayScoreInvokedWithPlayerOneWins()
    {
      SimulateGame(Player.One, Player.One, Player.One, Player.One);
      displayMock.Verify(x=>x.DisplayScore(GameScore.PlayerOneWins));
    }

    [Fact]
    public void Given_GameScore_When_PlayerTwoScoresFourTimes_Then_DisplayScoreInvokedWithPlayerTwoWins()
    {
      SimulateGame(Player.Two, Player.Two, Player.Two, Player.Two);
      displayMock.Verify(x=>x.DisplayScore(GameScore.PlayerTwoWins));
    }

    #endregion

    #region Should_ExpectedBehavior_When_StateUnderTest 

    [Fact]
    public void Should_InvokeDisplayScoreWith1515Once_When_BothPlayersScoreOnce()
    {
      SimulateGame(Player.One, Player.Two);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Fifteen} - {GameScore.Fifteen}"), Times.Once);
    }

    [Fact]
    public void Should_InvokeDisplayScoreWithLove40_When_PlayerTwoScoresThreeTimes()
    {
      SimulateGame(Player.Two, Player.Two, Player.Two);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Love} - {GameScore.Forty}"), Times.Once);
    }

    [Fact]
    public void Should_InvokeDisplayScoreWithDeuce_When_BothPlayersScoreThreeTimes()
    {
      SimulateFromDeuceGame();
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Deuce}"), Times.Once);
    }

    [Fact]
    public void Should_InvokeDisplayScoreWithAdvantageOnce_When_PlayersOneScoresAfterDeuce()
    {
      SimulateFromDeuceGame(Player.One);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Deuce}"), Times.Once);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.PlayerOneAdvantage}"), Times.Once);
    }

    [Fact]
    public void Should_InvokeDisplayScoreWithAdvantageOnce_When_PlayersTwoScoresAfterDeuce()
    {
      SimulateFromDeuceGame(Player.Two);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Deuce}"), Times.Once);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.PlayerTwoAdvantage}"), Times.Once);
    }

    [Fact]
    public void Should_InvokeDisplayScoreWithDeuceTwice_When_BothPlayersScoreAfterDeuce()
    {
      SimulateFromDeuceGame(Player.One, Player.Two);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Deuce}"), Times.Exactly(2));
    }
    
    #endregion

    private void SimulateGame(params Player[] playerScores)
    {
      foreach (Player player in playerScores)
      {
        if (player == Player.One)
        {
          gameScore.PlayerOneScores();
        }
        else if( player == Player.Two)
        {
          gameScore.PlayerTwoScores();
        }
      }
    }

    private void SimulateFromDeuceGame(params Player[] playerScores)
    {
      SimulateGame(
        Player.One,
        Player.Two,
        Player.One,
        Player.Two,
        Player.One,
        Player.Two);
      SimulateGame(playerScores);
    }
  }
}