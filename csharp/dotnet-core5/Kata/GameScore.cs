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
      if ((countPlayerOne == 3 && countPlayerTwo == 3) || (countPlayerOne == 4 && countPlayerTwo == 4))
      {
        display.DisplayScore($"{Deuce}");
      }
      else
      {
        display.DisplayScore($"{scoreOrder[countPlayerOne]} - {scoreOrder[countPlayerTwo]}");
      }
    }
  }
}
