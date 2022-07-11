using System;

namespace GameRound.Table
{
  public class Game
  {
    // fields go here! What do we need from the user? A number!
    public int YourNumber { get; set; }

    public Game(int yourNumber)
    {
      YourNumber = yourNumber;
    }
  }
}