using System;

namespace PointTask
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      bool pointInputNeeded = true;
      while (pointInputNeeded)
      {
        try
        {
          ConsolePointsInput consolePointsInput = new ConsolePointsInput();
          var listPoints = consolePointsInput.GetPoints();
          pointInputNeeded = false;
          if (listPoints[0] == listPoints[1])
          {
            Console.WriteLine("Points are equal.");
          }
          else
          {
            Console.WriteLine("Points aren't equal.");
          }
          Console.WriteLine(listPoints[0].Equals(listPoints[1]));
          Console.ReadKey();
        }
        catch (FormatException)
        {
          Console.WriteLine("Wrong format of point!");
        }
      }
    }
  }
}