using System;
using System.Collections.Generic;

namespace PointTask
{
  class ConsolePointsInput
  {
    List<Point> listOfPoints = new List<Point>();

    public List<Point> GetPoints()
    {
      for(int i = 1; i < 3; i++)
      {
        EnterTheCoordinates(i.ToString());
      }
      return listOfPoints;
    }

    private void EnterTheCoordinates(string param)
    {
      Console.WriteLine("\nEnter the coordinates of {0} point.", param);
      Console.WriteLine("X{0}: ", param);
      double X = double.Parse(Console.ReadLine());
      Console.WriteLine("Y{0}: ", param);
      double Y = double.Parse(Console.ReadLine());
      listOfPoints.Add(new Point(X, Y));
    }
  }
}