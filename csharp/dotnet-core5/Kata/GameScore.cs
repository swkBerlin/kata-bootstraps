using System.Collections.Generic;

namespace Kata
{
  internal class GameScore
  {
    internal const string Love = "Love";
    internal const string Fifteen = "15";
    internal const string Thirty = "30";
    internal const string Forty = "40";
    internal const string Deuce = "Deuce";
    internal const string PlayerOneAdvantage = "Advantage Player One";
    internal const string PlayerTwoAdvantage = "Advantage Player Two";
    internal const string PlayerOneWins = "Player One Wins!!!";
    internal const string PlayerTwoWins = "Player Two Wins!!!";
    private readonly IDisplay display;
    private readonly List<string> scoreOrder = new ()
    {
      Love, Fifteen, Thirty, Forty, Deuce
    };
    private int countPlayerOne;
    private int countPlayerTwo;
    internal GameScore(IDisplay display)
    {
      this.display = display;
      countPlayerOne = 0;
      countPlayerTwo = 0;
      BeautifyScore();
    }

    internal void PlayerOneScores()
    {
      countPlayerOne++;
      BeautifyScore();
    }

    internal void PlayerTwoScores()
    {
      countPlayerTwo++;
      BeautifyScore();
    }

    private void BeautifyScore()
    {
      // I'm not really happy :(
      // :__(
      if (IsGameDeuce())
      {
        display.DisplayScore($"{Deuce}");
      }
      else if (IsGamePlayerOneAdvantage())
      {
        display.DisplayScore($"{PlayerOneAdvantage}");
      }
      else if (IsPlayerTwoAdvantage())
      {
        display.DisplayScore($"{PlayerTwoAdvantage}");
      }
      else if (IsPlayerOneWins())
      {
        display.DisplayScore($"{PlayerOneWins}");
      }
      else if (IsPlayerTwoWins())
      {
        display.DisplayScore($"{PlayerTwoWins}");
      }
      else
      {
        display.DisplayScore($"{scoreOrder[countPlayerOne]} - {scoreOrder[countPlayerTwo]}");
      }
    }

    // TODO: make these better
    private bool IsPlayerTwoWins() => countPlayerTwo == 4;

    private bool IsPlayerOneWins() => countPlayerOne == 4;

    private bool IsPlayerTwoAdvantage() => countPlayerTwo > 3 && (countPlayerTwo - countPlayerOne == 1);

    private bool IsGamePlayerOneAdvantage() => countPlayerOne > 3 && (countPlayerOne - countPlayerTwo == 1);

    private bool IsGameDeuce() => (countPlayerOne == countPlayerTwo) && countPlayerOne > 2;
  }
}
