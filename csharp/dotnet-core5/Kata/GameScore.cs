namespace Kata
{
  internal class GameScore
  {
    private readonly IDisplay _display;
    internal GameScore(IDisplay display)
    {
      _display = display;
      _display.DisplayScore("Love - Love");
    }
    internal void PlayerScores()
    {
      _display.DisplayScore("");
    }
  }
}
