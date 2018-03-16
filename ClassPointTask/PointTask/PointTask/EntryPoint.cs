using System;

namespace PointTask
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      ConsolePointsInput consolePointsInput = new ConsolePointsInput();
      var listPoints = consolePointsInput.GetPoints();

      if(listPoints[0] == listPoints[1])
      {
        Console.WriteLine("Points are equal.");
      }
      else
      {
        Console.WriteLine("Points aren't equal.");
      }      
    }
  }
}