using System;

namespace PointTask
{
  class Point
  {      
    public const double EPSILON = 10e-3;

    public double X { get; set; }
    public double Y { get; set; }

    public Point(double X, double Y)
    {
      this.X = X;
      this.Y = Y;
    }

    public static bool operator ==(Point firstPoint, Point secondPoint)
    {
      return (Math.Abs(firstPoint.X - secondPoint.X) < EPSILON && (Math.Abs(firstPoint.Y - secondPoint.Y) < EPSILON));         
    }

    public static bool operator !=(Point firstPoint, Point secondPoint)
    {
      return (Math.Abs(firstPoint.X - secondPoint.X) < EPSILON && (Math.Abs(firstPoint.Y - secondPoint.Y) < EPSILON));
    } 
  }
}
