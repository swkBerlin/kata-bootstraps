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
      SimulateGame(Player.One, Player.One, Player.One, 
        Player.Two, Player.Two, Player.Two);
      displayMock.Verify(x => x.DisplayScore($"{GameScore.Deuce}"), Times.Once);
    }

    // TODO: Make pretty, ie refactor BeautifyScore method
    [Fact]
    public void Should_InvokeDisplayScoreWithDeuceTwice_When_PlayersAlternateScoringEightTimes()
    {
      SimulateGame(
        Player.One,
        Player.Two,
        Player.One,
        Player.Two,
        Player.One,
        Player.Two,
        Player.One,
        Player.Two
        );
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
  }
}