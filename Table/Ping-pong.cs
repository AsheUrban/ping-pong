using System;

namespace GameRound.Table
{
  public class Game
  {
    public int YourNumber { get; set; }

    public Game(int yourNumber)
    {
      YourNumber = yourNumber;
    }
  }
}