using System;
using System.Collections.Generic;

namespace PointTask
{
  class ConsolePointsInput
  {
    List<Point> listOfPoints = new List<Point>();
    public List<Point> GetPoints()
    {
      bool pointInputNeeded = true;
      while (pointInputNeeded)
      {
        try
        {
          Console.WriteLine("\nEnter the coordinates of first point.");
          Console.WriteLine("X1: ");
          double X1 = double.Parse(Console.ReadLine());
          Console.WriteLine("Y1: ");
          double Y1 = double.Parse(Console.ReadLine());
          listOfPoints.Add(new Point(X1, Y1));
          

          Console.WriteLine("\nEnter the coordinates of second point.");
          Console.WriteLine("X2: ");
          double X2 = double.Parse(Console.ReadLine());
          Console.WriteLine("Y2: ");
          double Y2 = double.Parse(Console.ReadLine());
          listOfPoints.Add(new Point(X2, Y2));
          pointInputNeeded = false;
        }
        catch (FormatException)
        {
          Console.WriteLine("Wrong format of point!");
        }
      }
      return listOfPoints;
    }
  }
}
