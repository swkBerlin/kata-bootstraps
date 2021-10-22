using System.Collections.Generic;

namespace Kata
{
  internal class GameScore
  {
    internal const string Love = "Love";
    internal const string Fifteen = "15";
    internal const string Thirty = "30";
    private readonly IDisplay _display;
    private readonly List<string> scoreOrder = new ()
    {
      Love, Fifteen, Thirty
    };
    private int countPlayerOne;
    private int countPlayerTwo;
    internal GameScore(IDisplay display)
    {
      _display = display;
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
      _display.DisplayScore($"{scoreOrder[countPlayerOne]} - {scoreOrder[countPlayerTwo]}");
    }


  }
}
