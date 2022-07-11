using System;
using GameRound.Table;

namespace GameRound
{
  public class Program
  {
    public static void Main ()
    {
      Console.WriteLine("Enter a number: ");
      string stringYourNumber = Console.ReadLine();
      int yourNumber = int.Parse(stringYourNumber);

      for (int number = 0; number <= yourNumber; number ++)
      {
       Console.WriteLine(number);
      }
    }
  }
}
  
  