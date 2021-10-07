namespace Kata
{
  public class GameScore
  {
    private readonly IDisplay _display;
    public GameScore(IDisplay display)
    {
      _display = display;
      _display.DisplayScore("Love - Love");
    }
    public void PlayerScores()
    {
      _display.DisplayScore("");
    }
  }
}
