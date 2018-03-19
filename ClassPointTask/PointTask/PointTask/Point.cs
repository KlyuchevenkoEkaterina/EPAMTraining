using System;

namespace PointTask
{
  class Point
  {
    public const double EPSILON = 10e-3;

    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y)
    {
      this.X = x;
      this.Y = y;
    }

    public static bool operator ==(Point firstPoint, Point secondPoint)
    {
      return (Math.Abs(firstPoint.X - secondPoint.X) < EPSILON && (Math.Abs(firstPoint.Y - secondPoint.Y) < EPSILON));
    }

    public static bool operator !=(Point firstPoint, Point secondPoint)
    {
      return (Math.Abs(firstPoint.X - secondPoint.X) < EPSILON && (Math.Abs(firstPoint.Y - secondPoint.Y) < EPSILON));
    }

    public override bool Equals(object obj)
    {
      Point point = (Point)obj;
      return this.X == point.X && this.Y == point.Y;
    }
  }
}
